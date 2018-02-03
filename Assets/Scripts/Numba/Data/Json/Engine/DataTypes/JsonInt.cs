using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent int wrapper.
    /// </summary>
    public class JsonInt : JsonValue
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
        public override JsonDataType Type { get { return JsonDataType.Int; } }

        /// <summary>
        /// Wrapped value.
        /// </summary>
        public int Value { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize object with int value.
        /// </summary>
        /// <param name="value">Initialize value.</param>
        public JsonInt(int value)
        {
            Value = value;
        }

        /// <summary>
        /// Parse string data as int value.
        /// </summary>
        /// <param name="jsonBoolData">String for parsing.</param>
        public JsonInt(string jsonIntData)
        {
            Value = Json.Parse<JsonNumber>(jsonIntData).ToInt();
        }

        public static implicit operator JsonInt(int value)
        {
            return new JsonInt(value);
        }

        /// <summary>
        /// Convert int value to json string representation.
        /// </summary>
        /// <returns>Json representation of this object.</returns>
        public override string ToString()
        {
            return Value.ToString().ToLower();
        }

        /// <summary>
        /// Compare with other object.
        /// </summary>
        /// <param name="obj">Object to compare with</param>
        /// <returns>True if other object is int or JsonInt and have same value, otherwise returns false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is int)
            {
                return Value.Equals((int)obj);
            }

            if (obj is JsonInt)
            {
                return Value.Equals(((JsonInt)obj).Value);
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