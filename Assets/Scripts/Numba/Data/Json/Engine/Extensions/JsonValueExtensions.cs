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
        public static bool Is<T>(this IJsonValue value) where T : IJsonValue
        {
            return value is T;
        }

        public static bool IsBool(this IJsonValue value)
        {
            return value.Is<JsonBool>();
        }

        public static bool IsByte(this IJsonValue value)
        {
            return value.Is<JsonByte>();
        }

        public static bool IsChar(this IJsonValue value)
        {
            return value.Is<JsonChar>();
        }

        public static bool IsDecimal(this IJsonValue value)
        {
            return value.Is<JsonDecimal>();
        }

        public static bool IsDouble(this IJsonValue value)
        {
            return value.Is<JsonDouble>();
        }

        public static bool IsFloat(this IJsonValue value)
        {
            return value.Is<JsonFloat>();
        }

        public static bool IsInt(this IJsonValue value)
        {
            return value.Is<JsonInt>();
        }

        public static bool IsLong(this IJsonValue value)
        {
            return value.Is<JsonLong>();
        }

        public static bool IsNull(this IJsonValue value)
        {
            return value.Is<JsonNull>();
        }

        public static bool IsNumber(this IJsonValue value)
        {
            return value.Is<JsonNumber>();
        }

        public static bool IsSByte(this IJsonValue value)
        {
            return value.Is<JsonSByte>();
        }

        public static bool IsShort(this IJsonValue value)
        {
            return value.Is<JsonShort>();
        }

        public static bool IsString(this IJsonValue value)
        {
            return value.Is<JsonString>();
        }

        public static bool IsUInt(this IJsonValue value)
        {
            return value.Is<JsonUInt>();
        }

        public static bool IsULong(this IJsonValue value)
        {
            return value.Is<JsonULong>();
        }

        public static bool IsUShort(this IJsonValue value)
        {
            return value.Is<JsonUShort>();
        }

        public static bool IsObject(this IJsonValue value)
        {
            return value.Is<JsonObject>();
        }

        public static bool IsArray(this IJsonValue value)
        {
            return value.Is<JsonArray>();
        }
        #endregion

        #region As
        public static T As<T>(this IJsonValue value) where T : IJsonValue
        {
            if (!value.Is<T>())
            {
                throw new JsonInvalidCastException();
            }

            return (T)value;
        }

        public static bool AsBool(this IJsonValue value)
        {
            return As<JsonBool>(value).Value;
        }

        public static byte AsByte(this IJsonValue value)
        {
            return As<JsonByte>(value).Value;
        }

        public static char AsChar(this IJsonValue value)
        {
            return As<JsonChar>(value).Value;
        }

        public static decimal AsDecimal(this IJsonValue value)
        {
            return As<JsonDecimal>(value).Value;
        }

        public static double AsDouble(this IJsonValue value)
        {
            return As<JsonDouble>(value).Value;
        }

        public static float AsFloat(this IJsonValue value)
        {
            return As<JsonFloat>(value).Value;
        }

        public static int AsInt(this IJsonValue value)
        {
            return As<JsonInt>(value).Value;
        }

        public static long AsLong(this IJsonValue value)
        {
            return As<JsonLong>(value).Value;
        }

        public static JsonNull AsNull(this IJsonValue value)
        {
            return As<JsonNull>(value);
        }

        public static JsonNumber AsNumber(this IJsonValue value)
        {
            return As<JsonNumber>(value);
        }

        public static sbyte AsSByte(this IJsonValue value)
        {
            return As<JsonSByte>(value).Value;
        }

        public static short AsShort(this IJsonValue value)
        {
            return As<JsonShort>(value).Value;
        }

        public static string AsString(this IJsonValue value)
        {
            return As<JsonString>(value).Value;
        }

        public static uint AsUInt(this IJsonValue value)
        {
            return As<JsonUInt>(value).Value;
        }

        public static ulong AsULong(this IJsonValue value)
        {
            return As<JsonULong>(value).Value;
        }

        public static ushort AsUShort(this IJsonValue value)
        {
            return As<JsonUShort>(value).Value;
        }

        public static JsonObject AsObject(this IJsonValue value)
        {
            return As<JsonObject>(value);
        }

        public static JsonArray AsArray(this IJsonValue value)
        {
            return As<JsonArray>(value);
        }
        #endregion
        #endregion
        #endregion
    }
}