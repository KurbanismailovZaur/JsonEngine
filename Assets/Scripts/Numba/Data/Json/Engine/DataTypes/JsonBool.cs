using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent bool wrapper.
    /// </summary>
    public class JsonBool : JsonValue
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
        public override JsonTypeCategory Category { get { return JsonTypeCategory.Bool; } }

        /// <summary>
        /// Returns type for this object.
        /// </summary>
        public override JsonDataType Type { get { return JsonDataType.Bool; } }

        /// <summary>
        /// Wrapped value.
        /// </summary>
        public bool Value { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize object with bool value.
        /// </summary>
        /// <param name="value">Initialize value.</param>
        public JsonBool(bool value)
        {
            Value = value;
        }

        /// <summary>
        /// Parse string data as bool value.
        /// </summary>
        /// <param name="jsonBoolData">String for parsing.</param>
        public JsonBool(string jsonBoolData)
        {
            Value = Json.Parse<JsonBool>(jsonBoolData).Value;
        }

        public static implicit operator JsonBool(bool value)
        {
            return new JsonBool(value);
        }

        /// <summary>
        /// Convert bool value to json string representation.
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
        /// <returns>True if other object is bool or JsonBool and have same value, otherwise returns false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is bool)
            {
                return Value.Equals((bool)obj);
            }

            if (obj is JsonBool)
            {
                return Value.Equals(((JsonBool)obj).Value);
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