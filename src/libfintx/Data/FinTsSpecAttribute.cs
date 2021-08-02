using System;
using System.Collections.Generic;
using System.Text;

namespace LibFinTx.Data
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    public class FinTsSpecAttribute : Attribute
    {
        public FinTsSpecAttribute(int major, int minor)
        {
            this.Version = new Version(major, minor);
        }
        public FinTsSpecAttribute(int major, int minor, int build)
        {
            this.Version = new Version(major, minor, build);
        }
        public FinTsSpecAttribute(int major, int minor, int build, int revision)
        {
            this.Version = new Version(major, minor, build, revision);
        }
        public FinTsSpecAttribute(string major, string minor)
        {
            this.Version = new Version(Convert.ToInt32(major), Convert.ToInt32(minor));
        }
        public FinTsSpecAttribute(string major, string minor, string build)
        {
            this.Version = new Version(Convert.ToInt32(major), Convert.ToInt32(minor), Convert.ToInt32(build));
        }
        public FinTsSpecAttribute(string major, string minor, string build, string revision)
        {
            this.Version = new Version(Convert.ToInt32(major), Convert.ToInt32(minor), Convert.ToInt32(build), Convert.ToInt32(revision));
        }
        public FinTsSpecAttribute(Version version)
        {
            this.Version = version;
        }

        public Version Version { get; }
    }
}
