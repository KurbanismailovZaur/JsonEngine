﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonString : IJsonValue, IJsonDataType<string>
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
        public JsonType Category { get { return JsonType.String; } }

        public JsonDataType Type { get { return JsonDataType.String; } }

        public string Value { get; set; }
        #endregion

        #region Methods
        public JsonString(string value)
        {
            Value = value.Replace("\"", "\\\"");
        }

        public static implicit operator JsonString(string value)
        {
            return new JsonString(value);
        }

        public static bool operator ==(JsonString thisObject, string otherObject)
        {
            return thisObject.Value == otherObject;
        }

        public static bool operator !=(JsonString thisObject, string otherObject)
        {
            return !(thisObject.Value == otherObject);
        }

        public static bool operator ==(JsonString thisObject, JsonString otherObject)
        {
            return thisObject.Value == otherObject.Value;
        }

        public static bool operator !=(JsonString thisObject, JsonString otherObject)
        {
            return !(thisObject.Value == otherObject.Value);
        }

        public override string ToString()
        {
            return Value == null ? "null" : string.Format("\"{0}\"", Value);
        }

        public override bool Equals(object obj)
        {
            if (obj is string)
            {
                return Value == (string)obj;
            }

            if (obj is JsonString)
            {
                return Value == (JsonString)obj;
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