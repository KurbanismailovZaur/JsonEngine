using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent sbyte wrapper.
    /// </summary>
    public class JsonSByte : JsonValue
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
        public override JsonDataType Type { get { return JsonDataType.SByte; } }

        /// <summary>
        /// Wrapped value.
        /// </summary>
        public sbyte Value { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize object with sbyte value.
        /// </summary>
        /// <param name="value">Initialize value.</param>
        public JsonSByte(sbyte value)
        {
            Value = value;
        }

        /// <summary>
        /// Parse string data as sbyte value.
        /// </summary>
        /// <param name="jsonSByteData">String for parsing.</param>
        public JsonSByte(string jsonSByteData)
        {
            Value = Json.Parse<JsonNumber>(jsonSByteData).ToSByte();
        }

        public static implicit operator JsonSByte(sbyte value)
        {
            return new JsonSByte(value);
        }

        /// <summary>
        /// Convert sbyte value to json string representation.
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
        /// <returns>True if other object is sbyte or JsonSByte and have same value, otherwise returns false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is sbyte)
            {
                return Value.Equals((sbyte)obj);
            }

            if (obj is JsonSByte)
            {
                return Value.Equals(((JsonSByte)obj).Value);
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