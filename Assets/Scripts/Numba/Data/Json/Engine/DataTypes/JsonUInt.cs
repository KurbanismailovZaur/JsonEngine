using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonUInt : IJsonValue, IJsonDataType<uint?>
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

        public uint? Value { get; set; }
        #endregion

        #region Methods
        public JsonUInt(uint? value)
        {
            Value = value;
        }

        public static implicit operator JsonUInt(uint? value)
        {
            return new JsonUInt(value);
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