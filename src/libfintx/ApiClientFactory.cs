using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibFinTx.Data;
using LibFinTx.Exceptions;

namespace LibFinTx
{
    public class ApiClientFactory
    {
        public static ApiClientFactory Instance { get; } = new ApiClientFactory();
        private Dictionary<Version, (Type type, Func<IApiClient> func)> _apiClients;
        public IEnumerable<Version> FinTsSpecVersionsSupported => this._apiClients.Keys;
        private ApiClientFactory()
        {
            _apiClients = new Dictionary<Version, (Type type, Func<IApiClient> func)>();
            RepeatSearchForImplemetations((assembly) => assembly.GetCustomAttributes(typeof(Data.FinTsSpecAttribute), false)?.Any() ?? false, (l, r) => l);
        }
        /// <summary>
        /// Delegate to skip assemblies conditionally.
        /// </summary>
        /// <remarks>
        /// Should only actually check the assembly involved!
        /// </remarks>
        /// <param name="first">The first type that was found.</param>
        /// <param name="second">The second type that was found</param>
        /// <returns>The type that should be used for the specified spec.</returns>
        public delegate bool AssemblyFilter(System.Reflection.Assembly assembly);
        /// <summary>
        /// Delegate to resolve a spec implementation collision.
        /// </summary>
        /// <param name="first">The first type that was found.</param>
        /// <param name="second">The second type that was found</param>
        /// <returns>The type that should be used for the specified spec.</returns>
        public delegate Type ResolveSpecImplementationCollision(Type first, Type second);
        public void RepeatSearchForImplemetations(AssemblyFilter assemblyFilter, ResolveSpecImplementationCollision collisionResolver)
        {
            var apiClients = new Dictionary<Version, (Type type, Func<IApiClient> func)>();
            var iApiClientType = typeof(IApiClient);
            var finTsSpecAttributeType = typeof(FinTsSpecAttribute);
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies().Where((assembly) => assemblyFilter(assembly)))
            {
                foreach (var type in assembly.GetTypes())
                {
                    if (iApiClientType.IsAssignableFrom(type) &&
                        iApiClientType.GetCustomAttributes(finTsSpecAttributeType, false)?.FirstOrDefault() is FinTsSpecAttribute finTsSpec)
                    {
                        if (apiClients.TryGetValue(finTsSpec.Version, out var existing))
                        {
                            var resolvedType = collisionResolver(existing.type, type);
                            var lambda = System.Linq.Expressions.Expression.Lambda(System.Linq.Expressions.Expression.New(type)).Compile();
                            apiClients[finTsSpec.Version] = (resolvedType, () => (IApiClient) lambda.DynamicInvoke());
                        }
                        else
                        {
                            var lambda = System.Linq.Expressions.Expression.Lambda(System.Linq.Expressions.Expression.New(type)).Compile();
                            apiClients[finTsSpec.Version] = (type, () => (IApiClient) lambda.DynamicInvoke());
                        }
                    }
                }
            }
            _apiClients = apiClients;
        }

        /// <summary>
        /// Creates a new <see cref="IApiClient"/> with the spec that is provided
        /// in <paramref name="version"/>.
        /// </summary>
        /// <exception cref="FinTsSpecHasNoImplementationException">Thrown when the <paramref name="version"/> has no matching <see cref="IApiClient"/> implementation.</exception>
        /// <param name="version">The spec version that is requested.</param>
        /// <returns>A valid <see cref="IApiClient"/> of the requested spec version.</returns>
        public IApiClient Produce(Version version)
        {
            if (this._apiClients.TryGetValue(version, out var tuple))
            {
                return tuple.func();
            }
            throw new FinTsSpecHasNoImplementationException(version);
        }
    }
}
