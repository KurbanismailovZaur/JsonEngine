using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonUShort : JsonValue, IJsonDataType<ushort>
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

        public override JsonDataType Type { get { return JsonDataType.UShort; } }

        public ushort Value { get; set; }
        #endregion

        #region Methods
        public JsonUShort(ushort value)
        {
            Value = value;
        }

        public static implicit operator JsonUShort(ushort value)
        {
            return new JsonUShort(value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is ushort)
            {
                return Value.Equals((ushort)obj);
            }

            if (obj is JsonUShort)
            {
                return Value.Equals(((JsonUShort)obj).Value);
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