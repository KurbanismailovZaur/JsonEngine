using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonShort : JsonValue, IJsonDataType<short>
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

        public override JsonDataType Type { get { return JsonDataType.Short; } }

        public short Value { get; set; }
        #endregion

        #region Methods
        public JsonShort(short value)
        {
            Value = value;
        }

        public static implicit operator JsonShort(short value)
        {
            return new JsonShort(value);
        }

        public static implicit operator short(JsonShort value)
        {
            return value.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is short)
            {
                return Value.Equals((short)obj);
            }

            if (obj is JsonShort)
            {
                return Value.Equals(((JsonShort)obj).Value);
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