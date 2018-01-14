using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonInt : IJsonValue, IJsonDataType<int>
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
        public JsonType Category { get { return JsonType.Number; } }

        public JsonDataType Type { get { return JsonDataType.Int; } }

        public int Value { get; set; }
        #endregion

        #region Methods
        public JsonInt(int value)
        {
            Value = value;
        }

        public static implicit operator JsonInt(int value)
        {
            return new JsonInt(value);
        }

        public override string ToString()
        {
            return Value.ToString().ToLower();
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}