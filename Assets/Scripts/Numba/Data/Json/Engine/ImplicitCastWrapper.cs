using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Extentions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    public class ImplicitCastWrapper
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
        private IJsonValue _value;
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        public IJsonValue Value { get { return _value; } }
        #endregion

        #region Constructors
        public ImplicitCastWrapper(IJsonValue value)
        {
            _value = value;
        }
        #endregion

        #region Methods
        #region Cast to engine types
        public static implicit operator bool(ImplicitCastWrapper caster)
        {
            return caster._value.AsBool();
        }

        public static implicit operator byte(ImplicitCastWrapper caster)
        {
            return caster._value.AsByte();
        }

        public static implicit operator char(ImplicitCastWrapper caster)
        {
            return caster._value.AsChar();
        }

        public static implicit operator decimal(ImplicitCastWrapper caster)
        {
            return caster._value.AsDecimal();
        }

        public static implicit operator double(ImplicitCastWrapper caster)
        {
            return caster._value.AsDouble();
        }

        public static implicit operator float(ImplicitCastWrapper caster)
        {
            return caster._value.AsFloat();
        }

        public static implicit operator int(ImplicitCastWrapper caster)
        {
            return caster._value.AsInt();
        }

        public static implicit operator long(ImplicitCastWrapper caster)
        {
            return caster._value.AsLong();
        }

        public static implicit operator JsonNull(ImplicitCastWrapper caster)
        {
            return caster._value.AsNull();
        }

        public static implicit operator JsonNumber(ImplicitCastWrapper caster)
        {
            return caster._value.AsNumber();
        }

        public static implicit operator sbyte(ImplicitCastWrapper caster)
        {
            return caster._value.AsSByte();
        }

        public static implicit operator short(ImplicitCastWrapper caster)
        {
            return caster._value.AsShort();
        }

        public static implicit operator string(ImplicitCastWrapper caster)
        {
            return caster._value.AsString();
        }

        public static implicit operator uint(ImplicitCastWrapper caster)
        {
            return caster._value.AsUInt();
        }

        public static implicit operator ulong(ImplicitCastWrapper caster)
        {
            return caster._value.AsULong();
        }

        public static implicit operator ushort(ImplicitCastWrapper caster)
        {
            return caster._value.AsUShort();
        }

        public static implicit operator JsonObject(ImplicitCastWrapper caster)
        {
            return caster._value.AsObject();
        }

        public static implicit operator JsonArray(ImplicitCastWrapper caster)
        {
            return caster._value.AsArray();
        }
        #endregion

        #region Cast to ImplicitCastWrapper
        public static implicit operator ImplicitCastWrapper(bool value)
        {
            return new ImplicitCastWrapper(new JsonBool(value));
        }

        public static implicit operator ImplicitCastWrapper(byte value)
        {
            return new ImplicitCastWrapper(new JsonByte(value));
        }

        public static implicit operator ImplicitCastWrapper(char value)
        {
            return new ImplicitCastWrapper(new JsonChar(value));
        }

        public static implicit operator ImplicitCastWrapper(decimal value)
        {
            return new ImplicitCastWrapper(new JsonDecimal(value));
        }

        public static implicit operator ImplicitCastWrapper(double value)
        {
            return new ImplicitCastWrapper(new JsonDouble(value));
        }

        public static implicit operator ImplicitCastWrapper(float value)
        {
            return new ImplicitCastWrapper(new JsonFloat(value));
        }

        public static implicit operator ImplicitCastWrapper(int value)
        {
            return new ImplicitCastWrapper(new JsonInt(value));
        }

        public static implicit operator ImplicitCastWrapper(long value)
        {
            return new ImplicitCastWrapper(new JsonLong(value));
        }

        public static implicit operator ImplicitCastWrapper(JsonNull value)
        {
            return new ImplicitCastWrapper(value);
        }

        public static implicit operator ImplicitCastWrapper(JsonNumber value)
        {
            return new ImplicitCastWrapper(value);
        }

        public static implicit operator ImplicitCastWrapper(sbyte value)
        {
            return new ImplicitCastWrapper(new JsonSByte(value));
        }

        public static implicit operator ImplicitCastWrapper(short value)
        {
            return new ImplicitCastWrapper(new JsonShort(value));
        }

        public static implicit operator ImplicitCastWrapper(string value)
        {
            return new ImplicitCastWrapper(new JsonString(value));
        }

        public static implicit operator ImplicitCastWrapper(uint value)
        {
            return new ImplicitCastWrapper(new JsonUInt(value));
        }

        public static implicit operator ImplicitCastWrapper(ulong value)
        {
            return new ImplicitCastWrapper(new JsonULong(value));
        }

        public static implicit operator ImplicitCastWrapper(ushort value)
        {
            return new ImplicitCastWrapper(new JsonUShort(value));
        }

        public static implicit operator ImplicitCastWrapper(JsonObject value)
        {
            return new ImplicitCastWrapper(value);
        }

        public static implicit operator ImplicitCastWrapper(JsonArray value)
        {
            return new ImplicitCastWrapper(value);
        }
        #endregion
        #endregion

        #region Events handlers
        #endregion
        #endregion
    }
}