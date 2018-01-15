using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonULong : JsonValue, IJsonDataType<ulong>
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

        public override JsonDataType Type { get { return JsonDataType.ULong; } }

        public ulong Value { get; set; }
        #endregion

        #region Methods
        public JsonULong(ulong value)
        {
            Value = value;
        }

        public static implicit operator JsonULong(ulong value)
        {
            return new JsonULong(value);
        }

        public static implicit operator ulong(JsonULong value)
        {
            return value.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is ulong)
            {
                return Value.Equals((ulong)obj);
            }

            if (obj is JsonULong)
            {
                return Value.Equals(((JsonULong)obj).Value);
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