using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonFloat : IJsonValue, IJsonDataType<float>
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

        public JsonDataType Type { get { return JsonDataType.Float; } }

        public float Value { get; set; }
        #endregion

        #region Methods
        public JsonFloat(float value)
        {
            Value = value;
        }

        public static implicit operator JsonFloat(float value)
        {
            return new JsonFloat(value);
        }

        public override string ToString()
        {
            if (float.IsInfinity(Value) || float.IsNaN(Value))
            {
                return string.Format("\"{0}\"", Value);
            }

            return Value.ToString("R", CultureInfo.InvariantCulture);
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}