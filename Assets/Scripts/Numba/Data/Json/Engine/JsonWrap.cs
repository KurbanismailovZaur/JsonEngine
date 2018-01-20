using Numba.Data.Json.Engine.DataTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    public class JsonWrap
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
        private JsonValue _value;
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        #endregion

        #region Constructors
        private JsonWrap() : this(new JsonNull()) { }

        public JsonWrap(JsonValue value)
        {
            _value = value ?? new JsonNull();
        }
        #endregion

        #region Methods
        public void SetValue(JsonValue value)
        {
            _value = value ?? new JsonNull();
        }
        #endregion

        #region Indexers
        #endregion

        #region Events handlers
        #endregion
        #endregion
    }
}