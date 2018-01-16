using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonInt : JsonValue, IJsonDataType<int>
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
        public override JsonType Category { get { return JsonType.Number; } }

        public override JsonDataType Type { get { return JsonDataType.Int; } }

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

        public override bool Equals(object obj)
        {
            if (obj is int)
            {
                return Value.Equals((int)obj);
            }

            if (obj is JsonInt)
            {
                return Value.Equals(((JsonInt)obj).Value);
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