using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonByte : JsonValue, IJsonDataType<byte>
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

        public override JsonDataType Type { get { return JsonDataType.Byte; } }

        public byte Value { get; set; }
        #endregion

        #region Methods
        public JsonByte(byte value)
        {
            Value = value;
        }

        public static implicit operator JsonByte(byte value)
        {
            return new JsonByte(value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is byte)
            {
                return Value.Equals((byte)obj);
            }

            if (obj is JsonByte)
            {
                return Value.Equals(((JsonByte)obj).Value);
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