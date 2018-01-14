using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonByte : IJsonValue, IJsonDataType<byte>
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
        public JsonType Type { get { return JsonType.Number; } }

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
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}