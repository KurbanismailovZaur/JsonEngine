using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent byte wrapper.
    /// </summary>
    public class JsonByte : JsonValue
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
        public override JsonDataType Type { get { return JsonDataType.Byte; } }

        /// <summary>
        /// Wrapped value.
        /// </summary>
        public byte Value { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize object with byte value.
        /// </summary>
        /// <param name="value">Initialize value.</param>
        public JsonByte(byte value)
        {
            Value = value;
        }

        /// <summary>
        /// Parse string data as byte value.
        /// </summary>
        /// <param name="jsonBoolData">String for parsing.</param>
        public JsonByte(string jsonByteData)
        {
            Value = Json.Parse<JsonNumber>(jsonByteData).ToByte();
        }

        public static implicit operator JsonByte(byte value)
        {
            return new JsonByte(value);
        }

        /// <summary>
        /// Convert byte value to json string representation.
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
        /// <returns>True if other object is byte or JsonByte and have same value, otherwise returns false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is byte)
            {
                return Value.Equals((byte)obj);
            }

            if (obj is JsonByte)
            {
                return Value.Equals(((JsonByte)obj).Value);
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