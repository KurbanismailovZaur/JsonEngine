using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonLong : JsonValue, IJsonDataType<long>
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

        public override JsonDataType Type { get { return JsonDataType.Long; } }

        public long Value { get; set; }
        #endregion

        #region Methods
        public JsonLong(long value)
        {
            Value = value;
        }

        public static implicit operator JsonLong(long value)
        {
            return new JsonLong(value);
        }

        public static implicit operator long(JsonLong value)
        {
            return value.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is long)
            {
                return Value.Equals((long)obj);
            }

            if (obj is JsonLong)
            {
                return Value.Equals(((JsonLong)obj).Value);
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