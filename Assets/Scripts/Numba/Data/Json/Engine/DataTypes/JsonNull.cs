using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonNull : JsonValue, IJsonDataType
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
        public override JsonType Category { get { return JsonType.Null; } }

        public override JsonDataType Type { get { return JsonDataType.Null; } }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "null";
        }

        public static bool operator ==(JsonNull jsonNull, object obj)
        {
            return obj is JsonNull || obj == null;
        }

        public static bool operator !=(JsonNull jsonNull, object obj)
        {
            return !(obj is JsonNull || obj == null);
        }

        public override bool Equals(object obj)
        {
            return obj is JsonNull || obj == null;
        }

        public override int GetHashCode()
        {
            return "Numba.Data.Json.Engine.DataTypes.JsonNull".GetHashCode();
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}