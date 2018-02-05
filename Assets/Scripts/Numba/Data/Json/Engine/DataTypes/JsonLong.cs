using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent long wrapper.
    /// </summary>
    public class JsonLong : JsonValue
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
        public override JsonDataType Type { get { return JsonDataType.Long; } }

        /// <summary>
        /// Wrapped value.
        /// </summary>
        public long Value { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize object with long value.
        /// </summary>
        /// <param name="value">Initialize value.</param>
        public JsonLong(long value)
        {
            Value = value;
        }

        /// <summary>
        /// Parse string data as long value.
        /// </summary>
        /// <param name="jsonLongData">String for parsing.</param>
        public JsonLong(string jsonLongData)
        {
            Value = Json.Parse<JsonNumber>(jsonLongData).ToLong();
        }

        public static implicit operator JsonLong(long value)
        {
            return new JsonLong(value);
        }

        /// <summary>
        /// Convert long value to json string representation.
        /// </summary>
        /// <returns>Json representation of this object.</returns>
        public override string ToString()
        {
            return Value.ToString();
        }

        /// <summary>
        /// Compare with other object.
        /// </summary>
        /// <param name="obj">Object to compare with</param>
        /// <returns>True if other object is long or JsonLong and have same value, otherwise returns false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is long)
            {
                return Value.Equals((long)obj);
            }

            if (obj is JsonLong)
            {
                return Value.Equals(((JsonLong)obj).Value);
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