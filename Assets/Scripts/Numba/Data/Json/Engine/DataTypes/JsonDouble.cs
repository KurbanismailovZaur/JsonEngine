using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonDouble : IJsonValue, IJsonDataType<double?>
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

        public double? Value { get; set; }
        #endregion

        #region Methods
        public JsonDouble(double? value)
        {
            Value = value;
        }

        public static implicit operator JsonDouble(double? value)
        {
            return new JsonDouble(value);
        }

        public override string ToString()
        {
            if (Value == null)
            {
                return "null";
            }

            if (double.IsInfinity(Value.Value) || double.IsNaN(Value.Value))
            {
                return string.Format("\"{0}\"", Value.Value);
            }

            return Value.Value.ToString("R", CultureInfo.InvariantCulture);
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}