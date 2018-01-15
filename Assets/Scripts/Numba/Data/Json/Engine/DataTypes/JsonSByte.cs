using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonSByte : JsonValue, IJsonDataType<sbyte>
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
        public override JsonType Category { get { return JsonType.Number; } }

        public override JsonDataType Type { get { return JsonDataType.SByte; } }

        public sbyte Value { get; set; }
        #endregion

        #region Methods
        public JsonSByte(sbyte value)
        {
            Value = value;
        }

        public static implicit operator JsonSByte(sbyte value)
        {
            return new JsonSByte(value);
        }

        public static implicit operator sbyte(JsonSByte value)
        {
            return value.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is sbyte)
            {
                return Value.Equals((sbyte)obj);
            }

            if (obj is JsonSByte)
            {
                return Value.Equals(((JsonSByte)obj).Value);
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