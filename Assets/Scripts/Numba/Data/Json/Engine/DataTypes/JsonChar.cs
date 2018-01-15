using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonChar : JsonValue, IJsonDataType<char>
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

        public override JsonDataType Type { get { return JsonDataType.Char; } }

        public char Value { get; set; }
        #endregion

        #region Methods
        public JsonChar(char value)
        {
            Value = value;
        }

        public static implicit operator JsonChar(char value)
        {
            return new JsonChar(value);
        }

        public static implicit operator char(JsonChar value)
        {
            return value.Value;
        }

        public override string ToString()
        {
            return string.Format("\"{0}\"", Value);
        }

        public override bool Equals(object obj)
        {
            if (obj is char)
            {
                return Value.Equals((char)obj);
            }

            if (obj is JsonChar)
            {
                return Value.Equals(((JsonChar)obj).Value);
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