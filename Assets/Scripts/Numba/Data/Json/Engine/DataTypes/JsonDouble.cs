using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonDouble : IJsonValue, IJsonDataType<double>
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

        public JsonDataType Type { get { return JsonDataType.Double; } }

        public double Value { get; set; }
        #endregion

        #region Methods
        public JsonDouble(double value)
        {
            Value = value;
        }

        public static implicit operator JsonDouble(double value)
        {
            return new JsonDouble(value);
        }

        public override string ToString()
        {
            if (double.IsInfinity(Value) || double.IsNaN(Value))
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