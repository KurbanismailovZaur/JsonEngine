using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    public abstract class JsonField
    {
        public abstract JsonString Name { get; set; }

        public abstract IJsonValue BaseValue { get; }
    }

    public class JsonField<T> : JsonField where T : IJsonValue
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

        private T _value;
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        public override JsonString Name
        {
            get { return _name; }

            set
            {
                _name = value;
            }
        }

        public override IJsonValue BaseValue { get { return Value; } }

        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion

        #region Methods
        public JsonField(string name, T value)
        {
            Name = name;
            Value = value;
        }

        public JsonField(JsonString name, T value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", _name, _value == null ? "null" : _value.ToString());
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}