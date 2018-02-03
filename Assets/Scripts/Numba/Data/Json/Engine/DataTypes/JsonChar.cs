using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent char wrapper.
    /// </summary>
    public class JsonChar : JsonValue
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
        public override JsonTypeCategory Category { get { return JsonTypeCategory.String; } }

        /// <summary>
        /// Returns type for this object.
        /// </summary>
        public override JsonDataType Type { get { return JsonDataType.Char; } }

        /// <summary>
        /// Wrapped value.
        /// </summary>
        public char Value { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize object with char value.
        /// </summary>
        /// <param name="value">Initialize value.</param>
        public JsonChar(char value)
        {
            Value = value;
        }

        /// <summary>
        /// Parse string data as char value.
        /// </summary>
        /// <param name="jsonBoolData">String for parsing.</param>
        public JsonChar(string jsonCharData)
        {
            Value = Json.Parse<JsonString>(jsonCharData).Value[0];
        }

        public static implicit operator JsonChar(char value)
        {
            return new JsonChar(value);
        }

        /// <summary>
        /// Convert char value to json string representation.
        /// </summary>
        /// <returns>Json representation of this object.</returns>
        public override string ToString()
        {
            return string.Format("\"{0}\"", Value);
        }

        /// <summary>
        /// Compare with other object.
        /// </summary>
        /// <param name="obj">Object to compare with</param>
        /// <returns>True if other object is char or JsonChar and have same value, otherwise returns false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is char)
            {
                return Value.Equals((char)obj);
            }

            if (obj is JsonChar)
            {
                return Value.Equals(((JsonChar)obj).Value);
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