using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonULong : IJsonValue, IJsonDataType<ulong>
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

        public JsonDataType Type { get { return JsonDataType.ULong; } }

        public ulong Value { get; set; }
        #endregion

        #region Methods
        public JsonULong(ulong value)
        {
            Value = value;
        }

        public static implicit operator JsonULong(ulong value)
        {
            return new JsonULong(value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}