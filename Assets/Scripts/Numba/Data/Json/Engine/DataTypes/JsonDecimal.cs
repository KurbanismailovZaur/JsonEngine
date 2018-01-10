using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonDecimal : IJsonValue, IJsonDataType<decimal?>
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

        public decimal? Value { get; set; }
        #endregion

        #region Methods
        public JsonDecimal(decimal? value)
        {
            Value = value;
        }

        public static implicit operator JsonDecimal(decimal? value)
        {
            return new JsonDecimal(value);
        }

        public override string ToString()
        {
            return Value == null ? "null" : Value.Value.ToString(CultureInfo.InvariantCulture);
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}