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
        public override JsonType Category { get { return JsonType.String; } }

        public override JsonDataType Type { get { return JsonDataType.String; } }

        public string Value { get; set; }
        #endregion

        #region Methods
        public JsonString(string value, bool parse = false)
        {
            if (!parse)
            {
                Value = value.Replace("\"", "\\\"");
            }
            else
            {
                Value = Json.Parse<JsonString>(value).Value;
            }
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