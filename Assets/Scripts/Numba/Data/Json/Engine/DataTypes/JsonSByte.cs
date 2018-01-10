using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonSByte : IJsonValue, IJsonDataType<sbyte?>
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

        public sbyte? Value { get; set; }
        #endregion

        #region Methods
        public JsonSByte(sbyte? value)
        {
            Value = value;
        }

        public static implicit operator JsonSByte(sbyte? value)
        {
            return new JsonSByte(value);
        }

        public override string ToString()
        {
            return Value == null ? "null" : Value.Value.ToString();
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}