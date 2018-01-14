using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonLong : IJsonValue, IJsonDataType<long>
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
        public JsonType Type { get { return JsonType.Number; } }

        public long Value { get; set; }
        #endregion

        #region Methods
        public JsonLong(long value)
        {
            Value = value;
        }

        public static implicit operator JsonLong(long value)
        {
            return new JsonLong(value);
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