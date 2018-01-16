using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonUInt : JsonValue, IJsonDataType<uint>
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

        public override JsonDataType Type { get { return JsonDataType.UInt; } }

        public uint Value { get; set; }
        #endregion

        #region Methods
        public JsonUInt(uint value)
        {
            Value = value;
        }

        public static implicit operator JsonUInt(uint value)
        {
            return new JsonUInt(value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is uint)
            {
                return Value.Equals((uint)obj);
            }

            if (obj is JsonUInt)
            {
                return Value.Equals(((JsonUInt)obj).Value);
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