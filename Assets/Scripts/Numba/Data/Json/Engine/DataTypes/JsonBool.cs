using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonBool : JsonValue, IJsonDataType<bool>
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
        public override JsonType Category { get { return JsonType.Bool; } }

        public override JsonDataType Type { get { return JsonDataType.Bool; } }

        public bool Value { get; set; }
        #endregion

        #region Methods
        public JsonBool(bool value)
        {
            Value = value;
        }

        public static implicit operator JsonBool(bool value)
        {
            return new JsonBool(value);
        }

        public override string ToString()
        {
            return Value.ToString().ToLower();
        }

        public override bool Equals(object obj)
        {
            if (obj is bool)
            {
                return Value.Equals((bool)obj);
            }

            if (obj is JsonBool)
            {
                return Value.Equals(((JsonBool)obj).Value);
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