using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent decimal wrapper.
    /// </summary>
    public class JsonDecimal : JsonValue
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
        /// <summary>
        /// Returns category for this object.
        /// </summary>
        public override JsonTypeCategory Category { get { return JsonTypeCategory.Number; } }

        /// <summary>
        /// Returns type for this object.
        /// </summary>
        public override JsonDataType Type { get { return JsonDataType.Decimal; } }

        /// <summary>
        /// Wrapped value.
        /// </summary>
        public decimal Value { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize object with decimal value.
        /// </summary>
        /// <param name="value">Initialize value.</param>
        public JsonDecimal(decimal value)
        {
            Value = value;
        }

        /// <summary>
        /// Parse string data as decimal value.
        /// </summary>
        /// <param name="jsonDecimalData">String for parsing.</param>
        public JsonDecimal(string jsonDecimalData)
        {
            Value = Json.Parse<JsonNumber>(jsonDecimalData).ToDecimal();
        }

        public static implicit operator JsonDecimal(decimal value)
        {
            return new JsonDecimal(value);
        }

        /// <summary>
        /// Convert decimal value to json string representation.
        /// </summary>
        /// <returns>Json representation of this object.</returns>
        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Compare with other object.
        /// </summary>
        /// <param name="obj">Object to compare with</param>
        /// <returns>True if other object is decimal or JsonDecimal and have same value, otherwise returns false.</returns>
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