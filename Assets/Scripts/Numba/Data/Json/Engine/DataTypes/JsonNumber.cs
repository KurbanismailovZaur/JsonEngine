using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public struct JsonNumber : IJsonValue, IJsonDataType
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
        public JsonType Type { get { return JsonType.Number; } }
        #endregion

        #region Methods
        public JsonNumber(string number)
        {
            _number = number;
        }

        #region Set number
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
            _number = number.ToString("R");
        }

        public void SetNumber(float number)
        {
            _number = number.ToString("R");
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
            return byte.Parse(_number);
        }

        public decimal ToDecimal()
        {
            return decimal.Parse(_number, System.Globalization.NumberStyles.Float);
        }

        public double ToDouble()
        {
            return double.Parse(_number, System.Globalization.NumberStyles.Float);
        }

        public float ToFloat()
        {
            return float.Parse(_number, System.Globalization.NumberStyles.Float);
        }

        public int ToInt()
        {
            return int.Parse(_number);
        }

        public long ToLong()
        {
            return long.Parse(_number);
        }

        public sbyte ToSByte()
        {
            return sbyte.Parse(_number);
        }

        public short ToShort()
        {
            return short.Parse(_number);
        }

        public uint ToUInt()
        {
            return uint.Parse(_number);
        }

        public ulong ToULong()
        {
            return ulong.Parse(_number);
        }

        public ushort ToUShort()
        {
            return ushort.Parse(_number);
        }
        #endregion
        public override string ToString()
        {
            return _number;
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}