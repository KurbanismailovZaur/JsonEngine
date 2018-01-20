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
        #endregion

        #region Events handlers
        #endregion
        #endregion
    }
}