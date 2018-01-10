using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonBool : IJsonValue, IJsonDataType<bool?>
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
        public JsonType Type { get { return JsonType.Bool; } }

        public bool? Value { get; set; }
        #endregion

        #region Methods
        public JsonBool(bool? value)
        {
            Value = value;
        }

        public static implicit operator JsonBool(bool? value)
        {
            return new JsonBool(value);
        }

        public override string ToString()
        {
            return Value == null ? "null" : Value.Value.ToString().ToLower();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}