using Numba.Data.Json.Engine;
using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Exceptions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.Extentions
{
    public static class JsonValueExtensions
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
        #region Is
        private static bool Is<T>(this JsonValue value) where T : JsonValue
        {
            return value is T;
        }

        public static bool IsBool(this JsonValue value)
        {
            return value.Is<JsonBool>();
        }

        public static bool IsByte(this JsonValue value)
        {
            return value.Is<JsonByte>();
        }

        public static bool IsChar(this JsonValue value)
        {
            return value.Is<JsonChar>();
        }

        public static bool IsDecimal(this JsonValue value)
        {
            return value.Is<JsonDecimal>();
        }

        public static bool IsDouble(this JsonValue value)
        {
            return value.Is<JsonDouble>();
        }

        public static bool IsFloat(this JsonValue value)
        {
            return value.Is<JsonFloat>();
        }

        public static bool IsInt(this JsonValue value)
        {
            return value.Is<JsonInt>();
        }

        public static bool IsLong(this JsonValue value)
        {
            return value.Is<JsonLong>();
        }

        public static bool IsNull(this JsonValue value)
        {
            return value.Is<JsonNull>();
        }

        public static bool IsNumber(this JsonValue value)
        {
            return value.Is<JsonNumber>();
        }

        public static bool IsSByte(this JsonValue value)
        {
            return value.Is<JsonSByte>();
        }

        public static bool IsShort(this JsonValue value)
        {
            return value.Is<JsonShort>();
        }

        public static bool IsString(this JsonValue value)
        {
            return value.Is<JsonString>();
        }

        public static bool IsUInt(this JsonValue value)
        {
            return value.Is<JsonUInt>();
        }

        public static bool IsULong(this JsonValue value)
        {
            return value.Is<JsonULong>();
        }

        public static bool IsUShort(this JsonValue value)
        {
            return value.Is<JsonUShort>();
        }

        public static bool IsObject(this JsonValue value)
        {
            return value.Is<JsonObject>();
        }

        public static bool IsArray(this JsonValue value)
        {
            return value.Is<JsonArray>();
        }
        #endregion

        #region As
        private static T As<T>(this JsonValue value) where T : JsonValue
        {
            if (!value.Is<T>())
            {
                throw new JsonInvalidCastException(string.Format("Source type (\"{0}\") can not be casted to \"{1}\"", value.GetType().Name, typeof(T).Name));
            }

            return (T)value;
        }

        public static bool AsBool(this JsonValue value)
        {
            return As<JsonBool>(value).Value;
        }

        public static byte AsByte(this JsonValue value)
        {
            return As<JsonByte>(value).Value;
        }

        public static char AsChar(this JsonValue value)
        {
            return As<JsonChar>(value).Value;
        }

        public static decimal AsDecimal(this JsonValue value)
        {
            return As<JsonDecimal>(value).Value;
        }

        public static double AsDouble(this JsonValue value)
        {
            return As<JsonDouble>(value).Value;
        }

        public static float AsFloat(this JsonValue value)
        {
            return As<JsonFloat>(value).Value;
        }

        public static int AsInt(this JsonValue value)
        {
            return As<JsonInt>(value).Value;
        }

        public static long AsLong(this JsonValue value)
        {
            return As<JsonLong>(value).Value;
        }

        public static JsonNull AsNull(this JsonValue value)
        {
            return As<JsonNull>(value);
        }

        public static JsonNumber AsNumber(this JsonValue value)
        {
            return As<JsonNumber>(value);
        }

        public static sbyte AsSByte(this JsonValue value)
        {
            return As<JsonSByte>(value).Value;
        }

        public static short AsShort(this JsonValue value)
        {
            return As<JsonShort>(value).Value;
        }

        public static string AsString(this JsonValue value)
        {
            return As<JsonString>(value).Value;
        }

        public static uint AsUInt(this JsonValue value)
        {
            return As<JsonUInt>(value).Value;
        }

        public static ulong AsULong(this JsonValue value)
        {
            return As<JsonULong>(value).Value;
        }

        public static ushort AsUShort(this JsonValue value)
        {
            return As<JsonUShort>(value).Value;
        }

        public static JsonObject AsObject(this JsonValue value)
        {
            return As<JsonObject>(value);
        }

        public static JsonArray AsArray(this JsonValue value)
        {
            return As<JsonArray>(value);
        }
        #endregion
        #endregion
        #endregion
    }
}