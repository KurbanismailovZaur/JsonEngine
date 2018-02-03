using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent ulong wrapper.
    /// </summary>
    public class JsonULong : JsonValue
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
        public override JsonDataType Type { get { return JsonDataType.ULong; } }

        /// <summary>
        /// Wrapped value.
        /// </summary>
        public ulong Value { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize object with ulong value.
        /// </summary>
        /// <param name="value">Initialize value.</param>
        public JsonULong(ulong value)
        {
            Value = value;
        }

        /// <summary>
        /// Parse string data as ulong value.
        /// </summary>
        /// <param name="jsonBoolData">String for parsing.</param>
        public JsonULong(string jsonULongData)
        {
            Value = Json.Parse<JsonNumber>(jsonULongData).ToULong();
        }

        public static implicit operator JsonULong(ulong value)
        {
            return new JsonULong(value);
        }

        /// <summary>
        /// Convert ulong value to json string representation.
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
        /// <returns>True if other object is ulong or JsonULong and have same value, otherwise returns false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is ulong)
            {
                return Value.Equals((ulong)obj);
            }

            if (obj is JsonULong)
            {
                return Value.Equals(((JsonULong)obj).Value);
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