using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent short wrapper.
    /// </summary>
    public class JsonShort : JsonValue
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
        public override JsonDataType Type { get { return JsonDataType.Short; } }

        /// <summary>
        /// Wrapped value.
        /// </summary>
        public short Value { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize object with short value.
        /// </summary>
        /// <param name="value">Initialize value.</param>
        public JsonShort(short value)
        {
            Value = value;
        }

        /// <summary>
        /// Parse string data as short value.
        /// </summary>
        /// <param name="jsonBoolData">String for parsing.</param>
        public JsonShort(string jsonShortData)
        {
            Value = Json.Parse<JsonNumber>(jsonShortData).ToShort();
        }

        public static implicit operator JsonShort(short value)
        {
            return new JsonShort(value);
        }

        /// <summary>
        /// Convert short value to json string representation.
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
        /// <returns>True if other object is short or JsonShort and have same value, otherwise returns false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is short)
            {
                return Value.Equals((short)obj);
            }

            if (obj is JsonShort)
            {
                return Value.Equals(((JsonShort)obj).Value);
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