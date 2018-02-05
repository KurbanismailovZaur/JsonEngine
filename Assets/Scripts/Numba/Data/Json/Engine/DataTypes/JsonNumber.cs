using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    /// <summary>
    /// Represent any numeric data type wrapper.
    /// </summary>
    public class JsonNumber : JsonValue
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
        /// <summary>
        /// Returns category for this object.
        /// </summary>
        public override JsonTypeCategory Category { get { return JsonTypeCategory.Number; } }

        /// <summary>
        /// Returns type for this object.
        /// </summary>
        public override JsonDataType Type { get { return JsonDataType.Number; } }
        #endregion

        #region Constructors
        /// <summary>
        /// Create JsonNumber based on JsonNumber.
        /// </summary>
        /// <param name="number">Number from which copy value.</param>
        public JsonNumber(JsonNumber number)
        {
            _number = number == null ? "0" : number._number;
        }

        /// <summary>
        /// Create JsonNumber based on byte.
        /// </summary>
        /// <param name="number">Number from which copy value.</param>
        public JsonNumber(byte number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Create JsonNumber based on decimal.
        /// </summary>
        /// <param name="number">Number from which copy value.</param>
        public JsonNumber(decimal number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Create JsonNumber based on double.
        /// </summary>
        /// <param name="number">Number from which copy value.</param>
        public JsonNumber(double number)
        {
            _number = number.ToString("R", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Create JsonNumber based on float.
        /// </summary>
        /// <param name="number">Number from which copy value.</param>
        public JsonNumber(float number)
        {
            _number = number.ToString("R", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Create JsonNumber based on int.
        /// </summary>
        /// <param name="number">Number from which copy value.</param>
        public JsonNumber(int number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Create JsonNumber based on long.
        /// </summary>
        /// <param name="number">Number from which copy value.</param>
        public JsonNumber(long number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Create JsonNumber based on sbyte.
        /// </summary>
        /// <param name="number">Number from which copy value.</param>
        public JsonNumber(sbyte number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Create JsonNumber based on short.
        /// </summary>
        /// <param name="number">Number from which copy value.</param>
        public JsonNumber(short number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Create JsonNumber based on uint.
        /// </summary>
        /// <param name="number">Number from which copy value.</param>
        public JsonNumber(uint number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Create JsonNumber based on ulong.
        /// </summary>
        /// <param name="number">Number from which copy value.</param>
        public JsonNumber(ulong number)
        {
            _number = number.ToString();
        }
        /// <summary>
        /// Create JsonNumber based on ushort.
        /// </summary>
        /// <param name="number">Number from which copy value.</param>
        public JsonNumber(ushort number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Parse string data as JsonNumber value.
        /// </summary>
        /// <param name="jsonNumberData">String for parsing.</param>
        public JsonNumber(string jsonNumberData)
        {
            _number = Json.Parse<JsonNumber>(jsonNumberData)._number;
        }
        #endregion

        #region Methods
        #region Set number
        /// <summary>
        /// Set number from JsonNumber.
        /// </summary>
        /// <param name="number">number from which copy value</param>
        public void SetNumber(JsonNumber number)
        {
            _number = number == null ? "0" : number._number;
        }

        /// <summary>
        /// Set number from byte.
        /// </summary>
        /// <param name="number">number from which copy value</param>
        public void SetNumber(byte number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Set number from decimal.
        /// </summary>
        /// <param name="number">number from which copy value</param>
        public void SetNumber(decimal number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Set number from double.
        /// </summary>
        /// <param name="number">number from which copy value</param>
        public void SetNumber(double number)
        {
            _number = number.ToString("R", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Set number from float.
        /// </summary>
        /// <param name="number">number from which copy value</param>
        public void SetNumber(float number)
        {
            _number = number.ToString("R", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Set number from int.
        /// </summary>
        /// <param name="number">number from which copy value</param>
        public void SetNumber(int number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Set number from long.
        /// </summary>
        /// <param name="number">number from which copy value</param>
        public void SetNumber(long number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Set number from sbyte.
        /// </summary>
        /// <param name="number">number from which copy value</param>
        public void SetNumber(sbyte number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Set number from short.
        /// </summary>
        /// <param name="number">number from which copy value</param>
        public void SetNumber(short number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Set number from uint.
        /// </summary>
        /// <param name="number">number from which copy value</param>
        public void SetNumber(uint number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Set number from ulong.
        /// </summary>
        /// <param name="number">number from which copy value</param>
        public void SetNumber(ulong number)
        {
            _number = number.ToString();
        }

        /// <summary>
        /// Set number from ushort.
        /// </summary>
        /// <param name="number">number from which copy value</param>
        public void SetNumber(ushort number)
        {
            _number = number.ToString();
        }
        #endregion

        #region To methods
        /// <summary>
        /// Convert number to byte.
        /// </summary>
        /// <returns>Returns byte representation of value.</returns>
        public byte ToByte()
        {
            return _number == null ? (byte)0 : byte.Parse(_number);
        }

        /// <summary>
        /// Convert number to decimal.
        /// </summary>
        /// <returns>Returns byte representation of value.</returns>
        public decimal ToDecimal()
        {
            return _number == null ? 0m : decimal.Parse(_number, NumberStyles.Float);
        }

        /// <summary>
        /// Convert number to double.
        /// </summary>
        /// <returns>Returns byte representation of value.</returns>
        public double ToDouble()
        {
            return _number == null ? 0d : double.Parse(_number, NumberStyles.Float);
        }

        /// <summary>
        /// Convert number to float.
        /// </summary>
        /// <returns>Returns byte representation of value.</returns>
        public float ToFloat()
        {
            return _number == null ? 0f : float.Parse(_number, NumberStyles.Float);
        }

        /// <summary>
        /// Convert number to int.
        /// </summary>
        /// <returns>Returns byte representation of value.</returns>
        public int ToInt()
        {
            return _number == null ? 0 : int.Parse(_number);
        }

        /// <summary>
        /// Convert number to long.
        /// </summary>
        /// <returns>Returns byte representation of value.</returns>
        public long ToLong()
        {
            return _number == null ? 0 : long.Parse(_number);
        }

        /// <summary>
        /// Convert number to sbyte.
        /// </summary>
        /// <returns>Returns byte representation of value.</returns>
        public sbyte ToSByte()
        {
            return _number == null ? (sbyte)0 : sbyte.Parse(_number);
        }

        /// <summary>
        /// Convert number to short.
        /// </summary>
        /// <returns>Returns byte representation of value.</returns>
        public short ToShort()
        {
            return _number == null ? (short)0 : short.Parse(_number);
        }

        /// <summary>
        /// Convert number to uint.
        /// </summary>
        /// <returns>Returns byte representation of value.</returns>
        public uint ToUInt()
        {
            return _number == null ? (uint)0 : uint.Parse(_number);
        }

        /// <summary>
        /// Convert number to ulong.
        /// </summary>
        /// <returns>Returns byte representation of value.</returns>
        public ulong ToULong()
        {
            return _number == null ? (ulong)0 : ulong.Parse(_number);
        }

        /// <summary>
        /// Convert number to ushort.
        /// </summary>
        /// <returns>Returns byte representation of value.</returns>
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

        /// <summary>
        /// Convert JsonNumber value to json string representation.
        /// </summary>
        /// <returns>Json representation of this object.</returns>
        public override string ToString()
        {
            return _number ?? "0";
        }

        /// <summary>
        /// Compare with other object.
        /// </summary>
        /// <param name="obj">Object to compare with</param>
        /// <returns>True if other object is JsonNumber and have same value, otherwise returns false.</returns>
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