﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonShort : IJsonValue, IJsonDataType<short?>
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

        public short? Value { get; set; }
        #endregion

        #region Methods
        public JsonShort(short? value)
        {
            Value = value;
        }

        public static implicit operator JsonShort(short? value)
        {
            return new JsonShort(value);
        }

        public override string ToString()
        {
            return Value == null ? "null" : Value.Value.ToString();
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}