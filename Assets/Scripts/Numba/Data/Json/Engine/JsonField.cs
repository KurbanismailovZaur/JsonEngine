using Numba.Data.Json.Engine.DataTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    /// <summary>
    /// Represent field in JsonObject class. Used only with JsonObject.
    /// </summary>
    public class JsonField
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
        private JsonString _name;

        private JsonValue _value;
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        /// <summary>
        /// Name of this field.
        /// </summary>
        public JsonString Name
        {
            get { return _name; }
            set { _name = value ?? string.Empty; }
        }

        /// <summary>
        /// Value associated with this field.
        /// </summary>
        public JsonValue Value
        {
            get { return _value; }
            set { _value = value ?? JsonNull.value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Create JsonField with specifics name and value.
        /// </summary>
        /// <param name="name">Name of field.</param>
        /// <param name="value">Value associated with this field.</param>
        public JsonField(JsonString name, JsonValue value)
        {
            _name = name;
            _value = value ?? JsonNull.value;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Convert field to json string representation.
        /// </summary>
        /// <returns>String representation of this object.</returns>
        public override string ToString()
        {
            return string.Format("{0}:{1}", _name, _value.ToString());
        }
        #endregion

        #region Events handlers
        #endregion
        #endregion
    }
}