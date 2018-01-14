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
        public static JsonField<T> AsField<T>(this JsonField field) where T : IJsonValue
        {
            if (!(field is JsonField<T>))
            {
                throw new JsonInvalidCastException();
            }

            return (JsonField<T>)field;
        }

        public static JsonField<JsonBool> AsBoolField(this JsonField field)
        {
            return AsField<JsonBool>(field);
        }

        public static JsonField<JsonByte> AsByteField(this JsonField field)
        {
            return AsField<JsonByte>(field);
        }

        public static JsonField<JsonChar> AsCharField(this JsonField field)
        {
            return AsField<JsonChar>(field);
        }

        public static JsonField<JsonDecimal> AsDecimalField(this JsonField field)
        {
            return AsField<JsonDecimal>(field);
        }

        public static JsonField<JsonDouble> AsDoubleField(this JsonField field)
        {
            return AsField<JsonDouble>(field);
        }

        public static JsonField<JsonFloat> AsFloatField(this JsonField field)
        {
            return AsField<JsonFloat>(field);
        }

        public static JsonField<JsonInt> AsIntField(this JsonField field)
        {
            return AsField<JsonInt>(field);
        }

        public static JsonField<JsonLong> AsLongField(this JsonField field)
        {
            return AsField<JsonLong>(field);
        }

        public static JsonField<JsonNull> AsNullField(this JsonField field)
        {
            return AsField<JsonNull>(field);
        }

        public static JsonField<JsonNumber> AsNumberField(this JsonField field)
        {
            return AsField<JsonNumber>(field);
        }

        public static JsonField<JsonSByte> AsSByteField(this JsonField field)
        {
            return AsField<JsonSByte>(field);
        }

        public static JsonField<JsonShort> AsShortField(this JsonField field)
        {
            return AsField<JsonShort>(field);
        }

        public static JsonField<JsonString> AsStringField(this JsonField field)
        {
            return AsField<JsonString>(field);
        }

        public static JsonField<JsonUInt> AsUIntField(this JsonField field)
        {
            return AsField<JsonUInt>(field);
        }

        public static JsonField<JsonULong> AsULongField(this JsonField field)
        {
            return AsField<JsonULong>(field);
        }

        public static JsonField<JsonUShort> AsUShortField(this JsonField field)
        {
            return AsField<JsonUShort>(field);
        }

        public static JsonField<JsonObject> AsObjectField(this JsonField field)
        {
            return AsField<JsonObject>(field);
        }

        public static JsonField<JsonArray> AsArrayField(this JsonField field)
        {
            return AsField<JsonArray>(field);
        }
        #endregion
        #endregion
    }
}