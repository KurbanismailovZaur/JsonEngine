using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonFloat : JsonValue, IJsonDataType<float>
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

        public override JsonDataType Type { get { return JsonDataType.Float; } }

        public float Value { get; set; }
        #endregion

        #region Methods
        public JsonFloat(float value)
        {
            Value = value;
        }

        public JsonFloat(string jsonFloatData)
        {
            Value = Json.Parse<JsonNumber>(jsonFloatData).ToFloat();
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

        public override bool Equals(object obj)
        {
            if (obj is float)
            {
                return Value.Equals((float)obj);
            }

            if (obj is JsonFloat)
            {
                return Value.Equals(((JsonFloat)obj).Value);
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