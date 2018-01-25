﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonDecimal : JsonValue, IJsonDataType<decimal>
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
        public override JsonTypeCategory Category { get { return JsonTypeCategory.Number; } }

        public override JsonDataType Type { get { return JsonDataType.Decimal; } }

        public decimal Value { get; set; }
        #endregion

        #region Methods
        public JsonDecimal(decimal value)
        {
            Value = value;
        }

        public JsonDecimal(string jsonDecimalData)
        {
            Value = Json.Parse<JsonNumber>(jsonDecimalData).ToDecimal();
        }

        public static implicit operator JsonDecimal(decimal value)
        {
            return new JsonDecimal(value);
        }

        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }

        public override bool Equals(object obj)
        {
            if (obj is decimal)
            {
                return Value.Equals((decimal)obj);
            }

            if (obj is JsonDecimal)
            {
                return Value.Equals(((JsonDecimal)obj).Value);
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