using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibFinTx.FinTs3_0
{
    public class MessageBuilder
    {
        private readonly StringBuilder _stringBuilder;
        public const char DataSeparator = '+';
        public const char DataElementSeparator = ':';
        public const char EndMessage = '\'';
        public const char EscapeCharacter = '?';
        public const char BinaryData = '@';
        public MessageBuilder(string messageHead)
        {
            this._stringBuilder = new StringBuilder();
            this._stringBuilder.Append(messageHead);
        }

        public void Append(string[] segments)
        {
            this._stringBuilder.Append(DataSeparator);
            foreach(var segment in segments)
            {
                this._stringBuilder.Append(DataElementSeparator);
                foreach (var c in segment)
                {
                    switch (c)
                    {
                        case DataSeparator:
                        case DataElementSeparator:
                        case EndMessage:
                        case BinaryData:
                        case EscapeCharacter:
                            this._stringBuilder.Append(EscapeCharacter);
                            goto default;
                        default:
                            this._stringBuilder.Append(c);
                            break;
                    }
                }
            }
        }
        public void Append(string segment)
        {
            this._stringBuilder.Append(DataSeparator);
            foreach (var c in segment)
            {
                switch (c)
                {
                    case DataSeparator:
                    case DataElementSeparator:
                    case EndMessage:
                    case EscapeCharacter:
                        this._stringBuilder.Append(EscapeCharacter);
                        goto default;
                    default:
                        this._stringBuilder.Append(c);
                        break;
                }
            }
        }
        public void Append(byte[] data)
        {
            this._stringBuilder.Append(BinaryData);
            this._stringBuilder.Append(data.Length);
            this._stringBuilder.Append(BinaryData);
            foreach (var b in data)
            {
                this._stringBuilder.Append((char)b);
            }
        }

        public override string ToString()
        {
            return _stringBuilder.ToString() + EndMessage;
        }
    }
}
