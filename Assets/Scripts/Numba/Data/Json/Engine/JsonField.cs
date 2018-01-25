using Numba.Data.Json.Engine.DataTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
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
        public JsonString Name
        {
            get { return _name; }
            set { _name = value ?? string.Empty; }
        }

        public JsonValue Value
        {
            get { return _value; }
            set { _value = value ?? JsonNull.value; }
        }
        #endregion

        #region Constructors
        public JsonField(JsonString name, JsonValue value)
        {
            _name = name;
            _value = value ?? JsonNull.value;
        }
        #endregion

        #region Methods
        #region Set value
        #endregion

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