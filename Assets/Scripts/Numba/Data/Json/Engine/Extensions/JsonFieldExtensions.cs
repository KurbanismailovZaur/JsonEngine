using Numba.Data.Json.Engine;
using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Exceptions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.Extentions
{
    public static class JsonFieldExtensions
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
        #endregion

        #region Methods
        public static JsonField<T> As<T>(this JsonField field) where T : IJsonValue
        {
            if (!(field is JsonField<T>))
            {
                throw new JsonInvalidCastException();
            }

            return (JsonField<T>)field;
        }

        public static JsonField<JsonBool> AsBool(this JsonField field)
        {
            return As<JsonBool>(field);
        }

        public static JsonField<JsonByte> AsByte(this JsonField field)
        {
            return As<JsonByte>(field);
        }

        public static JsonField<JsonChar> AsChar(this JsonField field)
        {
            return As<JsonChar>(field);
        }

        public static JsonField<JsonDecimal> AsDecimal(this JsonField field)
        {
            return As<JsonDecimal>(field);
        }

        public static JsonField<JsonDouble> AsDouble(this JsonField field)
        {
            return As<JsonDouble>(field);
        }

        public static JsonField<JsonFloat> AsFloat(this JsonField field)
        {
            return As<JsonFloat>(field);
        }

        public static JsonField<JsonInt> AsInt(this JsonField field)
        {
            return As<JsonInt>(field);
        }

        public static JsonField<JsonLong> AsLong(this JsonField field)
        {
            return As<JsonLong>(field);
        }

        public static JsonField<JsonNull> AsNull(this JsonField field)
        {
            return As<JsonNull>(field);
        }

        public static JsonField<JsonNumber> AsNumber(this JsonField field)
        {
            return As<JsonNumber>(field);
        }

        public static JsonField<JsonSByte> AsSByte(this JsonField field)
        {
            return As<JsonSByte>(field);
        }

        public static JsonField<JsonShort> AsShort(this JsonField field)
        {
            return As<JsonShort>(field);
        }

        public static JsonField<JsonString> AsString(this JsonField field)
        {
            return As<JsonString>(field);
        }

        public static JsonField<JsonUInt> AsUInt(this JsonField field)
        {
            return As<JsonUInt>(field);
        }

        public static JsonField<JsonULong> AsULong(this JsonField field)
        {
            return As<JsonULong>(field);
        }

        public static JsonField<JsonUShort> AsUShort(this JsonField field)
        {
            return As<JsonUShort>(field);
        }

        public static JsonField<JsonObject> AsObject(this JsonField field)
        {
            return As<JsonObject>(field);
        }

        public static JsonField<JsonArray> AsArray(this JsonField field)
        {
            return As<JsonArray>(field);
        }
        #endregion
        #endregion
    }
}