using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent double wrapper.
    /// </summary>
    public class JsonDouble : JsonValue
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
        public override JsonDataType Type { get { return JsonDataType.Double; } }

        /// <summary>
        /// Wrapped value.
        /// </summary>
        public double Value { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize object with double value.
        /// </summary>
        /// <param name="value">Initialize value.</param>
        public JsonDouble(double value)
        {
            Value = value;
        }

        /// <summary>
        /// Parse string data as double value.
        /// </summary>
        /// <param name="jsonDoubleData">String for parsing.</param>
        public JsonDouble(string jsonDoubleData)
        {
            Value = Json.Parse<JsonNumber>(jsonDoubleData).ToDouble();
        }

        public static implicit operator JsonDouble(double value)
        {
            return new JsonDouble(value);
        }

        /// <summary>
        /// Convert double value to json string representation.
        /// </summary>
        /// <returns>Json representation of this object.</returns>
        public override string ToString()
        {
            if (double.IsInfinity(Value) || double.IsNaN(Value))
            {
                return string.Format("\"{0}\"", Value);
            }

            return Value.ToString("R", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Compare with other object.
        /// </summary>
        /// <param name="obj">Object to compare with</param>
        /// <returns>True if other object is double or JsonDouble and have same value, otherwise returns false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is double)
            {
                return Value.Equals((double)obj);
            }

            if (obj is JsonDouble)
            {
                return Value.Equals(((JsonDouble)obj).Value);
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