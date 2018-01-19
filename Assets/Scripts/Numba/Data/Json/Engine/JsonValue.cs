using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Exceptions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    public abstract class JsonValue
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
        public abstract JsonType Category { get; }
        public abstract JsonDataType Type { get; }
        #endregion

        #region Constructors
        #endregion

        #region Methods
        #region Implicit cast from system types
        public static implicit operator JsonValue(bool value)
        {
            return new JsonBool(value);
        }

        public static implicit operator JsonValue(byte value)
        {
            return new JsonByte(value);
        }

        public static implicit operator JsonValue(char value)
        {
            return new JsonChar(value);
        }

        public static implicit operator JsonValue(decimal value)
        {
            return new JsonDecimal(value);
        }

        public static implicit operator JsonValue(double value)
        {
            return new JsonDouble(value);
        }

        public static implicit operator JsonValue(float value)
        {
            return new JsonFloat(value);
        }

        public static implicit operator JsonValue(int value)
        {
            return new JsonInt(value);
        }

        public static implicit operator JsonValue(long value)
        {
            return new JsonLong(value);
        }

        public static implicit operator JsonValue(sbyte value)
        {
            return new JsonSByte(value);
        }

        public static implicit operator JsonValue(short value)
        {
            return new JsonShort(value);
        }

        public static implicit operator JsonValue(string value)
        {
            return new JsonString(value);
        }

        public static implicit operator JsonValue(uint value)
        {
            return new JsonUInt(value);
        }

        public static implicit operator JsonValue(ulong value)
        {
            return new JsonULong(value);
        }

        public static implicit operator JsonValue(ushort value)
        {
            return new JsonUShort(value);
        }
        #endregion

        #region Is
        private bool Is<T>() where T : JsonValue
        {
            return this is T;
        }

        public bool IsBool()
        {
            return Is<JsonBool>();
        }

        public bool IsByte()
        {
            return Is<JsonByte>();
        }

        public bool IsChar()
        {
            return Is<JsonChar>();
        }

        public bool IsDecimal()
        {
            return Is<JsonDecimal>();
        }

        public bool IsDouble()
        {
            return Is<JsonDouble>();
        }

        public bool IsFloat()
        {
            return Is<JsonFloat>();
        }

        public bool IsInt()
        {
            return Is<JsonInt>();
        }

        public bool IsLong()
        {
            return Is<JsonLong>();
        }

        public bool IsNull()
        {
            return Is<JsonNull>();
        }

        public bool IsNumber()
        {
            return Is<JsonNumber>();
        }

        public bool IsSByte()
        {
            return Is<JsonSByte>();
        }

        public bool IsShort()
        {
            return Is<JsonShort>();
        }

        public bool IsString()
        {
            return Is<JsonString>();
        }

        public bool IsUInt()
        {
            return Is<JsonUInt>();
        }

        public bool IsULong()
        {
            return Is<JsonULong>();
        }

        public bool IsUShort()
        {
            return Is<JsonUShort>();
        }

        public bool IsObject()
        {
            return Is<JsonObject>();
        }

        public bool IsArray()
        {
            return Is<JsonArray>();
        }
        #endregion

        #region As
        private T As<T>() where T : JsonValue
        {
            if (!Is<T>())
            {
                throw new JsonInvalidCastException(string.Format("Source type (\"{0}\") can not be casted to \"{1}\"", GetType().Name, typeof(T).Name));
            }

            return (T)this;
        }

        public bool AsBool()
        {
            return As<JsonBool>().Value;
        }

        public byte AsByte()
        {
            return As<JsonByte>().Value;
        }

        public char AsChar()
        {
            return As<JsonChar>().Value;
        }

        public decimal AsDecimal()
        {
            return As<JsonDecimal>().Value;
        }

        public double AsDouble()
        {
            return As<JsonDouble>().Value;
        }

        public float AsFloat()
        {
            return As<JsonFloat>().Value;
        }

        public int AsInt()
        {
            return As<JsonInt>().Value;
        }

        public long AsLong()
        {
            return As<JsonLong>().Value;
        }

        public JsonNull AsNull()
        {
            return As<JsonNull>();
        }

        public JsonNumber AsNumber()
        {
            return As<JsonNumber>();
        }

        public sbyte AsSByte()
        {
            return As<JsonSByte>().Value;
        }

        public short AsShort()
        {
            return As<JsonShort>().Value;
        }

        public string AsString()
        {
            return As<JsonString>().Value;
        }

        public uint AsUInt()
        {
            return As<JsonUInt>().Value;
        }

        public ulong AsULong()
        {
            return As<JsonULong>().Value;
        }

        public ushort AsUShort()
        {
            return As<JsonUShort>().Value;
        }

        public JsonObject AsObject()
        {
            return As<JsonObject>();
        }

        public JsonArray AsArray()
        {
            return As<JsonArray>();
        }
        #endregion
        #endregion

        #region Events handlers
        #endregion
        #endregion
    }
}