using Numba.Data.Json.Engine.DataTypes.Exceptions;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonString : JsonValue, IJsonDataType<string>
    {
        #region Entities
        #region Enums
        #endregion

        #region Delegates
        #endregion

        #region Structures
        #endregion

        #region Classes
        #endregion

        #region Interfaces
        #endregion
        #endregion

        #region Fields
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        public override JsonTypeCategory Category { get { return JsonTypeCategory.String; } }

        public override JsonDataType Type { get { return JsonDataType.String; } }

        public string Value { get; set; }
        #endregion

        #region Methods
        public JsonString(string value, bool parse = false)
        {
            if (!parse)
            {
                StringBuilder builder = new StringBuilder(value);
                CheckString(builder);

                Value = builder.ToString();
            }
            else
            {
                Value = Json.Parse<JsonString>(value).Value;
            }
        }

        private  void CheckString(StringBuilder builder)
        {
            for (int i = 0; i < builder.Length; i++)
            {
                if (builder[i] == '\\')
                {
                    if (i + 1 == builder.Length)
                    {
                        throw new JsonStringFormatException("Backslash is no have escape sequence symbol");
                    }

                    switch (builder[i + 1])
                    {
                        case '"':
                        case '\\':
                        case '/':
                        case 'b':
                        case 'f':
                        case 'n':
                        case 'r':
                        case 't':
                            i += 1;
                            continue;
                        case 'u':
                            if (i + 5 > builder.Length - 1)
                            {
                                throw new JsonStringFormatException("The 'u' escape symbol no have 4 symbols at the right");
                            }

                            if (!IsHexString(builder.ToString(i + 2, 4)))
                            {
                                throw new JsonStringFormatException("The 'u' escape symbol no have 4 hexodecimal digits at the right");
                            }

                            i += 5;
                            continue;
                        default:
                            throw new JsonStringFormatException("Not allowed escape sequence");
                    }
                }
                else if (builder[i] == '"')
                {
                    if (i - 1 < 0)
                    {
                        throw new JsonStringFormatException("Quotes no have backslash");
                    }

                    if (builder[i - 1] != '\\')
                    {
                        throw new JsonStringFormatException("Quotes no have backslash");
                    }
                    else
                    {
                        int backslashCount = 0;
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (builder[j] == '\\')
                            {
                                backslashCount += 1;
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (backslashCount % 2 == 0)
                        {
                            throw new JsonStringFormatException("Quotes no have backslash");
                        }
                    }
                }
                else if (char.IsControl(builder[i]))
                {
                    throw new JsonStringFormatException("Escape sequences are not supported");
                }
            }
        }

        private bool IsHexChar(char c)
        {
            return (c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F');
        }

        private bool IsHexString(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!IsHexChar(s[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static implicit operator JsonString(string value)
        {
            return new JsonString(value);
        }

        public static bool operator ==(JsonString thisObject, string otherObject)
        {
            return thisObject.Value == otherObject;
        }

        public static bool operator !=(JsonString thisObject, string otherObject)
        {
            return !(thisObject.Value == otherObject);
        }

        public static bool operator ==(JsonString thisObject, JsonString otherObject)
        {
            return thisObject.Value == otherObject.Value;
        }

        public static bool operator !=(JsonString thisObject, JsonString otherObject)
        {
            return !(thisObject.Value == otherObject.Value);
        }

        public override string ToString()
        {
            return Value == null ? "null" : string.Format("\"{0}\"", Value);
        }

        public override bool Equals(object obj)
        {
            if (obj is string)
            {
                return Value.Equals((string)obj);
            }

            if (obj is JsonString)
            {
                return Value.Equals(((JsonString)obj).Value);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}