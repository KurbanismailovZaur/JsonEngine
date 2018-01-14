using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonChar : IJsonValue, IJsonDataType<char>
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

        public JsonDataType Type { get { return JsonDataType.Char; } }

        public char Value { get; set; }
        #endregion

        #region Methods
        public JsonChar(char value)
        {
            Value = value;
        }

        public static implicit operator JsonChar(char value)
        {
            return new JsonChar(value);
        }

        public override string ToString()
        {
            return string.Format("\"{0}\"", Value);
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}