using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent uint wrapper.
    /// </summary>
    public class JsonUInt : JsonValue
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
        public override JsonDataType Type { get { return JsonDataType.UInt; } }

        /// <summary>
        /// Wrapped value.
        /// </summary>
        public uint Value { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize object with uint value.
        /// </summary>
        /// <param name="value">Initialize value.</param>
        public JsonUInt(uint value)
        {
            Value = value;
        }

        /// <summary>
        /// Parse string data as uint value.
        /// </summary>
        /// <param name="jsonBoolData">String for parsing.</param>
        public JsonUInt(string jsonUIntData)
        {
            Value = Json.Parse<JsonNumber>(jsonUIntData).ToUInt();
        }

        public static implicit operator JsonUInt(uint value)
        {
            return new JsonUInt(value);
        }

        /// <summary>
        /// Convert uint value to json string representation.
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
        /// <returns>True if other object is uint or JsonUInt and have same value, otherwise returns false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is uint)
            {
                return Value.Equals((uint)obj);
            }

            if (obj is JsonUInt)
            {
                return Value.Equals(((JsonUInt)obj).Value);
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