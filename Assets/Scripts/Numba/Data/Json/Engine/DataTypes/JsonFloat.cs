using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent float wrapper.
    /// </summary>
    public class JsonFloat : JsonValue
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
        public override JsonDataType Type { get { return JsonDataType.Float; } }

        /// <summary>
        /// Wrapped value.
        /// </summary>
        public float Value { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize object with float value.
        /// </summary>
        /// <param name="value">Initialize value.</param>
        public JsonFloat(float value)
        {
            Value = value;
        }

        /// <summary>
        /// Parse string data as float value.
        /// </summary>
        /// <param name="jsonBoolData">String for parsing.</param>
        public JsonFloat(string jsonFloatData)
        {
            Value = Json.Parse<JsonNumber>(jsonFloatData).ToFloat();
        }

        public static implicit operator JsonFloat(float value)
        {
            return new JsonFloat(value);
        }

        /// <summary>
        /// Convert float value to json string representation.
        /// </summary>
        /// <returns>Json representation of this object.</returns>
        public override string ToString()
        {
            if (float.IsInfinity(Value) || float.IsNaN(Value))
            {
                return string.Format("\"{0}\"", Value);
            }

            return Value.ToString("R", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Compare with other object.
        /// </summary>
        /// <param name="obj">Object to compare with</param>
        /// <returns>True if other object is float or JsonFloat and have same value, otherwise returns false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is float)
            {
                return Value.Equals((float)obj);
            }

            if (obj is JsonFloat)
            {
                return Value.Equals(((JsonFloat)obj).Value);
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