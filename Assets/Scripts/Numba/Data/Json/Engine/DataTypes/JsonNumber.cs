using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public class JsonNumber : JsonValue, IJsonDataType
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
        private string _number;
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        public override JsonTypeCategory Category { get { return JsonTypeCategory.Number; } }

        public override JsonDataType Type { get { return JsonDataType.Number; } }
        #endregion

        #region Constructors
        public JsonNumber(JsonNumber number)
        {
            _number = number == null ? "0" : number._number;
        }

        public JsonNumber(byte number)
        {
            _number = number.ToString();
        }

        public JsonNumber(decimal number)
        {
            _number = number.ToString();
        }

        public JsonNumber(double number)
        {
            _number = number.ToString("R", CultureInfo.InvariantCulture);
        }

        public JsonNumber(float number)
        {
            _number = number.ToString("R", CultureInfo.InvariantCulture);
        }

        public JsonNumber(int number)
        {
            _number = number.ToString();
        }

        public JsonNumber(long number)
        {
            _number = number.ToString();
        }

        public JsonNumber(sbyte number)
        {
            _number = number.ToString();
        }

        public JsonNumber(short number)
        {
            _number = number.ToString();
        }

        public JsonNumber(uint number)
        {
            _number = number.ToString();
        }

        public JsonNumber(ulong number)
        {
            _number = number.ToString();
        }

        public JsonNumber(ushort number)
        {
            _number = number.ToString();
        }

        public JsonNumber(string jsonNumberData)
        {
            _number = Json.Parse<JsonNumber>(jsonNumberData)._number;
        }
        #endregion

        #region Methods
        #region Set number
        public void SetNumber(JsonNumber number)
        {
            _number = number == null ? "0" : number._number;
        }

        public void SetNumber(byte number)
        {
            _number = number.ToString();
        }

        public void SetNumber(decimal number)
        {
            _number = number.ToString();
        }

        public void SetNumber(double number)
        {
            _number = number.ToString("R", CultureInfo.InvariantCulture);
        }

        public void SetNumber(float number)
        {
            _number = number.ToString("R", CultureInfo.InvariantCulture);
        }

        public void SetNumber(int number)
        {
            _number = number.ToString();
        }

        public void SetNumber(long number)
        {
            _number = number.ToString();
        }

        public void SetNumber(sbyte number)
        {
            _number = number.ToString();
        }

        public void SetNumber(short number)
        {
            _number = number.ToString();
        }

        public void SetNumber(uint number)
        {
            _number = number.ToString();
        }

        public void SetNumber(ulong number)
        {
            _number = number.ToString();
        }

        public void SetNumber(ushort number)
        {
            _number = number.ToString();
        }
        #endregion

        #region To methods
        public byte ToByte()
        {
            return _number == null ? (byte)0 : byte.Parse(_number);
        }

        public decimal ToDecimal()
        {
            return _number == null ? 0m : decimal.Parse(_number, NumberStyles.Float);
        }

        public double ToDouble()
        {
            return _number == null ? 0d : double.Parse(_number, NumberStyles.Float);
        }

        public float ToFloat()
        {
            return _number == null ? 0f : float.Parse(_number, NumberStyles.Float);
        }

        public int ToInt()
        {
            return _number == null ? 0 : int.Parse(_number);
        }

        public long ToLong()
        {
            return _number == null ? 0 : long.Parse(_number);
        }

        public sbyte ToSByte()
        {
            return _number == null ? (sbyte)0 : sbyte.Parse(_number);
        }

        public short ToShort()
        {
            return _number == null ? (short)0 : short.Parse(_number);
        }

        public uint ToUInt()
        {
            return _number == null ? (uint)0 : uint.Parse(_number);
        }

        public ulong ToULong()
        {
            return _number == null ? (ulong)0 : ulong.Parse(_number);
        }

        public ushort ToUShort()
        {
            return _number == null ? (ushort)0 : ushort.Parse(_number);
        }
        #endregion

        #region Implicit casts
        #region From system types
        public static implicit operator JsonNumber(byte value)
        {
            return new JsonNumber(value);
        }

        public static implicit operator JsonNumber(decimal value)
        {
            return new JsonNumber(value);
        }

        public static implicit operator JsonNumber(double value)
        {
            return new JsonNumber(value);
        }

        public static implicit operator JsonNumber(float value)
        {
            return new JsonNumber(value);
        }

        public static implicit operator JsonNumber(int value)
        {
            return new JsonNumber(value);
        }

        public static implicit operator JsonNumber(long value)
        {
            return new JsonNumber(value);
        }

        public static implicit operator JsonNumber(sbyte value)
        {
            return new JsonNumber(value);
        }

        public static implicit operator JsonNumber(short value)
        {
            return new JsonNumber(value);
        }

        public static implicit operator JsonNumber(uint value)
        {
            return new JsonNumber(value);
        }

        public static implicit operator JsonNumber(ulong value)
        {
            return new JsonNumber(value);
        }

        public static implicit operator JsonNumber(ushort value)
        {
            return new JsonNumber(value);
        }
        #endregion
        #endregion

        public override string ToString()
        {
            return _number ?? "0";
        }

        public override bool Equals(object obj)
        {
            if (obj is JsonNumber)
            {
                return _number.Equals(((JsonNumber)obj)._number);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return _number.GetHashCode();
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}