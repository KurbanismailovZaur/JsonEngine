using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent ushort wrapper.
    /// </summary>
    public class JsonUShort : JsonValue
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
        public override JsonDataType Type { get { return JsonDataType.UShort; } }

        /// <summary>
        /// Wrapped value.
        /// </summary>
        public ushort Value { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize object with ushort value.
        /// </summary>
        /// <param name="value">Initialize value.</param>
        public JsonUShort(ushort value)
        {
            Value = value;
        }

        /// <summary>
        /// Parse string data as ushort value.
        /// </summary>
        /// <param name="jsonUShortData">String for parsing.</param>
        public JsonUShort(string jsonUShortData)
        {
            Value = Json.Parse<JsonNumber>(jsonUShortData).ToUShort();
        }

        public static implicit operator JsonUShort(ushort value)
        {
            return new JsonUShort(value);
        }

        /// <summary>
        /// Convert ushort value to json string representation.
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
        /// <returns>True if other object is ushort or JsonUShort and have same value, otherwise returns false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is ushort)
            {
                return Value.Equals((ushort)obj);
            }

            if (obj is JsonUShort)
            {
                return Value.Equals(((JsonUShort)obj).Value);
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