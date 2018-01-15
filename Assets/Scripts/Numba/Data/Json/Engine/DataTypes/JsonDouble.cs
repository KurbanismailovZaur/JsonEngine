using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonDouble : JsonValue, IJsonDataType<double>
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

        public override JsonDataType Type { get { return JsonDataType.Double; } }

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

        public static implicit operator double(JsonDouble value)
        {
            return value.Value;
        }

        public override string ToString()
        {
            if (double.IsInfinity(Value) || double.IsNaN(Value))
            {
                return string.Format("\"{0}\"", Value);
            }

            return Value.ToString("R", CultureInfo.InvariantCulture);
        }

        public override bool Equals(object obj)
        {
            if (obj is double)
            {
                return Value.Equals((double)obj);
            }

            if (obj is JsonDouble)
            {
                return Value.Equals(((JsonDouble)obj).Value);
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