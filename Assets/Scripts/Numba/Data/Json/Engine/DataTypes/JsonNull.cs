using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent null value wrapper.
    /// </summary>
    public class JsonNull : JsonValue
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
        /// <summary>
        /// Represent null value.
        /// </summary>
        public static readonly JsonNull value = new JsonNull();
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        /// <summary>
        /// Returns category for this object.
        /// </summary>
        public override JsonTypeCategory Category { get { return JsonTypeCategory.Null; } }

        /// <summary>
        /// Returns type for this object.
        /// </summary>
        public override JsonDataType Type { get { return JsonDataType.Null; } }
        #endregion

        #region Methods
        #region Constructors
        private JsonNull() { }

        /// <summary>
        /// Parse string data as null value.
        /// </summary>
        /// <param name="jsonBoolData">String for parsing.</param>
        public JsonNull(string jsonNullData)
        {
            // Just check on null data in string
            Json.Parse<JsonNull>(jsonNullData);
        }
        #endregion

        /// <summary>
        /// Convert null value to json string representation.
        /// </summary>
        /// <returns>Json representation of this object.</returns>
        public override string ToString()
        {
            return "null";
        }

        public static bool operator ==(JsonNull jsonNull, object obj)
        {
            return obj is JsonNull || obj == null;
        }

        public static bool operator !=(JsonNull jsonNull, object obj)
        {
            return !(obj is JsonNull || obj == null);
        }

        /// <summary>
        /// Compare with other object.
        /// </summary>
        /// <param name="obj">Object to compare with</param>
        /// <returns>True if other object is JsonNull or equals null, otherwise returns false.</returns>
        public override bool Equals(object obj)
        {
            return obj is JsonNull || obj == null;
        }

        public override int GetHashCode()
        {
            return "Numba.Data.Json.Engine.DataTypes.JsonNull".GetHashCode();
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}