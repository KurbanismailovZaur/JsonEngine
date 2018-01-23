using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    public class JsonWrap : IEnumerable
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
        private JsonValue _value;
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        public JsonValue Value
        {
            get { return _value; }
            set { _value = value ?? JsonNull.value; }
        }

        public JsonType Category { get { return _value.Category; } }

        public JsonDataType Type { get { return _value.Type; } }

        public int Count
        {
            get
            {
                if (_value is JsonObject)
                {
                    return ((JsonObject)_value).Count;
                }
                else if (_value is JsonArray)
                {
                    return ((JsonArray)_value).Count;
                }

                throw new JsonInvalidCastException(string.Format("\"{0}\" does not have property with name \"Count\"", _value.GetType().Name));
            }
        }
        #endregion

        #region Constructors
        private JsonWrap() { }

        private JsonWrap(JsonValue value)
        {
            _value = value;
        }
        #endregion

        #region Methods
        #region Implicit cast from system types and JsonValue
        public static implicit operator JsonWrap(JsonValue value)
        {
            return new JsonWrap(value);
        }

        public static implicit operator JsonWrap(bool value)
        {
            return new JsonBool(value);
        }

        public static implicit operator JsonWrap(byte value)
        {
            return new JsonByte(value);
        }

        public static implicit operator JsonWrap(char value)
        {
            return new JsonChar(value);
        }

        public static implicit operator JsonWrap(decimal value)
        {
            return new JsonDecimal(value);
        }

        public static implicit operator JsonWrap(double value)
        {
            return new JsonDouble(value);
        }

        public static implicit operator JsonWrap(float value)
        {
            return new JsonFloat(value);
        }

        public static implicit operator JsonWrap(int value)
        {
            return new JsonInt(value);
        }

        public static implicit operator JsonWrap(long value)
        {
            return new JsonLong(value);
        }

        public static implicit operator JsonWrap(sbyte value)
        {
            return new JsonSByte(value);
        }

        public static implicit operator JsonWrap(short value)
        {
            return new JsonShort(value);
        }

        public static implicit operator JsonWrap(string value)
        {
            return new JsonString(value);
        }

        public static implicit operator JsonWrap(uint value)
        {
            return new JsonUInt(value);
        }

        public static implicit operator JsonWrap(ulong value)
        {
            return new JsonULong(value);
        }

        public static implicit operator JsonWrap(ushort value)
        {
            return new JsonUShort(value);
        }
        #endregion

        #region Implicit cast to system types and JsonValue
        public static implicit operator JsonValue(JsonWrap wrap)
        {
            return wrap.Value;
        }

        public static implicit operator bool(JsonWrap wrap)
        {
            return ((JsonBool)wrap.Value).Value;
        }

        public static implicit operator byte(JsonWrap wrap)
        {
            return ((JsonByte)wrap.Value).Value;
        }

        public static implicit operator char(JsonWrap wrap)
        {
            return ((JsonChar)wrap.Value).Value;
        }

        public static implicit operator decimal(JsonWrap wrap)
        {
            return ((JsonDecimal)wrap.Value).Value;
        }

        public static implicit operator double(JsonWrap wrap)
        {
            return ((JsonDouble)wrap.Value).Value;
        }

        public static implicit operator float(JsonWrap wrap)
        {
            return ((JsonFloat)wrap.Value).Value;
        }

        public static implicit operator int(JsonWrap wrap)
        {
            return ((JsonInt)wrap.Value).Value;
        }

        public static implicit operator long(JsonWrap wrap)
        {
            return ((JsonLong)wrap.Value).Value;
        }

        public static implicit operator JsonNull(JsonWrap wrap)
        {
            return ((JsonNull)wrap.Value);
        }

        public static implicit operator JsonNumber(JsonWrap wrap)
        {
            return ((JsonNumber)wrap.Value);
        }

        public static implicit operator sbyte(JsonWrap wrap)
        {
            return ((JsonSByte)wrap.Value).Value;
        }

        public static implicit operator short(JsonWrap wrap)
        {
            return ((JsonShort)wrap.Value).Value;
        }

        public static implicit operator string(JsonWrap wrap)
        {
            return ((JsonString)wrap.Value).Value;
        }

        public static implicit operator uint(JsonWrap wrap)
        {
            return ((JsonUInt)wrap.Value).Value;
        }

        public static implicit operator ulong(JsonWrap wrap)
        {
            return ((JsonULong)wrap.Value).Value;
        }

        public static implicit operator ushort(JsonWrap wrap)
        {
            return ((JsonUShort)wrap.Value).Value;
        }

        public static implicit operator JsonObject(JsonWrap wrap)
        {
            return ((JsonObject)wrap.Value);
        }

        public static implicit operator JsonArray(JsonWrap wrap)
        {
            return ((JsonArray)wrap.Value);
        }
        #endregion

        private void CheckCastTo<T>(string exceptionMessage)
        {
            if (!(_value is T))
            {
                throw new JsonInvalidCastException(exceptionMessage);
            }
        }

        private void CastToObjectOrArrayAndInvoke(Action objectAction, Action arrayAction)
        {
            if (_value is JsonObject)
            {
                objectAction.Invoke();
                return;
            }

            if (_value is JsonObject)
            {
                arrayAction.Invoke();
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not be casted to \"JsonObject\" or \"JsonArray\"", _value.GetType().Name));
        }

        private T CastToObjectOrArrayAndInvoke<T>(Func<T> objectFunc, Func<T> arrayFunc)
        {
            if (_value is JsonObject)
            {
                return objectFunc.Invoke();
            }

            if (_value is JsonObject)
            {
                return arrayFunc.Invoke();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not be casted to \"JsonObject\" or \"JsonArray\"", _value.GetType().Name));
        }

        #region JsonNumber
        #region Set number
        public void SetNumber(JsonNumber number)
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            ((JsonNumber)_value).SetNumber(number);
        }

        public void SetNumber(byte number)
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            ((JsonNumber)_value).SetNumber(number);
        }

        public void SetNumber(decimal number)
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            ((JsonNumber)_value).SetNumber(number);
        }

        public void SetNumber(double number)
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            ((JsonNumber)_value).SetNumber(number);
        }

        public void SetNumber(float number)
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            ((JsonNumber)_value).SetNumber(number);
        }

        public void SetNumber(int number)
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            ((JsonNumber)_value).SetNumber(number);
        }

        public void SetNumber(long number)
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            ((JsonNumber)_value).SetNumber(number);
        }

        public void SetNumber(sbyte number)
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            ((JsonNumber)_value).SetNumber(number);
        }

        public void SetNumber(short number)
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            ((JsonNumber)_value).SetNumber(number);
        }

        public void SetNumber(uint number)
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            ((JsonNumber)_value).SetNumber(number);
        }

        public void SetNumber(ulong number)
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            ((JsonNumber)_value).SetNumber(number);
        }

        public void SetNumber(ushort number)
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            ((JsonNumber)_value).SetNumber(number);
        }
        #endregion

        public byte NumberToByte()
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            return ((JsonNumber)_value).ToByte();
        }

        public decimal NumberToDecimal()
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            return ((JsonNumber)_value).ToDecimal();
        }

        public double NumberToDouble()
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            return ((JsonNumber)_value).ToDouble();
        }

        public float NumberToFloat()
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            return ((JsonNumber)_value).ToFloat();
        }

        public int NumberToInt()
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            return ((JsonNumber)_value).ToInt();
        }

        public long NumberToLong()
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            return ((JsonNumber)_value).ToLong();
        }

        public sbyte NumberToSByte()
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            return ((JsonNumber)_value).ToSByte();
        }

        public short NumberToShort()
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            return ((JsonNumber)_value).ToShort();
        }

        public uint NumberToUInt()
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            return ((JsonNumber)_value).ToUInt();
        }

        public ulong NumberToULong()
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            return ((JsonNumber)_value).ToULong();
        }

        public ushort NumberToUShort()
        {
            CheckCastTo<JsonNumber>(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));

            return ((JsonNumber)_value).ToUShort();
        }
        #endregion

        #region Common method for jsonObject and JsonArray
        public IEnumerator GetEnumerator()
        {
            if (_value is JsonObject || _value is JsonArray)
            {
                return ((IEnumerable)_value).GetEnumerator();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" does not implement \"IEnumerable\" or \"IEnumerable<T>\" interface", _value.GetType().Name));
        }

        public void RemoveAt(int index)
        {
            CastToObjectOrArrayAndInvoke(() => { ((JsonObject)_value).RemoveAt(index); }, () => { ((JsonArray)_value).RemoveAt(index); });
        }

        public void RemoveRange(int index, int count)
        {
            CastToObjectOrArrayAndInvoke(() => { ((JsonObject)_value).RemoveRange(index, count); }, () => { ((JsonArray)_value).RemoveRange(index, count); });
        }

        public void Clear()
        {
            CastToObjectOrArrayAndInvoke(() => { ((JsonObject)_value).Clear(); }, () => { ((JsonArray)_value).Clear(); });
        }

        #region Get values
        public JsonValue GetValue(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetValue(index); }, () => { return ((JsonArray)_value)[index]; });
        }

        public bool GetBool(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetBool(index); }, () => { return ((JsonArray)_value).GetBool(index); });
        }

        public byte GetByte(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetByte(index); }, () => { return ((JsonArray)_value).GetByte(index); });
        }

        public char GetChar(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetChar(index); }, () => { return ((JsonArray)_value).GetChar(index); });
        }

        public decimal GetDecimal(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetDecimal(index); }, () => { return ((JsonArray)_value).GetDecimal(index); });
        }

        public double GetDouble(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetDouble(index); }, () => { return ((JsonArray)_value).GetDouble(index); });
        }

        public float GetFloat(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetFloat(index); }, () => { return ((JsonArray)_value).GetFloat(index); });
        }

        public int GetInt(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetInt(index); }, () => { return ((JsonArray)_value).GetInt(index); });
        }

        public long GetLong(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetLong(index); }, () => { return ((JsonArray)_value).GetLong(index); });
        }

        public JsonNull GetNull(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetNull(index); }, () => { return ((JsonArray)_value).GetNull(index); });
        }

        public JsonNumber GetNumber(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetNumber(index); }, () => { return ((JsonArray)_value).GetNumber(index); });
        }

        public sbyte GetSByte(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetSByte(index); }, () => { return ((JsonArray)_value).GetSByte(index); });
        }

        public short GetShort(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetShort(index); }, () => { return ((JsonArray)_value).GetShort(index); });
        }

        public string GetString(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetString(index); }, () => { return ((JsonArray)_value).GetString(index); });
        }

        public uint GetUInt(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetUInt(index); }, () => { return ((JsonArray)_value).GetUInt(index); });
        }

        public ulong GetULong(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetULong(index); }, () => { return ((JsonArray)_value).GetULong(index); });
        }

        public ushort GetUShort(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetUShort(index); }, () => { return ((JsonArray)_value).GetUShort(index); });
        }

        public JsonObject GetObject(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetObject(index); }, () => { return ((JsonArray)_value).GetObject(index); });
        }

        public JsonArray GetArray(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetArray(index); }, () => { return ((JsonArray)_value).GetArray(index); });
        }
        #endregion

        public void Swap(int first, int second)
        {
            CastToObjectOrArrayAndInvoke(() => { ((JsonObject)_value).SwapFields(first, second); }, () => { ((JsonArray)_value).SwapValues(first, second); });
        }

        public bool CheckNull(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).CheckNull(index); }, () => { return ((JsonArray)_value).CheckNull(index); });
        }
        #endregion

        #region JsonObject
        public void Add(JsonField field)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            ((JsonObject)_value).Add(field);
        }

        public void Add(string name, JsonValue value)
        {
            Add(new JsonField(name, value));
        }

        public void AddRange(IEnumerable<JsonField> fields)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            ((JsonObject)_value).AddRange(fields);
        }

        public void Insert(int index, JsonField field)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            ((JsonObject)_value).Insert(index, field);
        }

        public void Insert(int index, string name, JsonValue value)
        {
            Insert(index, new JsonField(name, value));
        }

        public void InsertRange(int index, IEnumerable<JsonField> fields)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            ((JsonObject)_value).InsertRange(index, fields);
        }

        public void InsertOrAppend(int index, JsonField field)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            ((JsonObject)_value).InsertOrAppend(index, field);
        }

        public void InsertOrAppend(int index, string name, JsonValue value)
        {
            InsertOrAppend(index, new JsonField(name, value));
        }

        public bool RemoveField(JsonField field)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).Remove(field);
        }

        public bool RemoveField(string fieldName)
        {
            return RemoveField(GetField(fieldName));
        }

        public int RemoveAll(Predicate<JsonField> match)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).RemoveAll(match);
        }

        public JsonField GetField(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetField(fieldName);
        }

        public JsonField GetFieldAt(int index)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetFieldAt(index);
        }

        public bool HasField(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).HasField(fieldName);
        }

        public bool Contains(JsonField field)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).Contains(field);
        }

        public int IndexOfField(JsonField field)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).IndexOf(field);
        }

        public int IndexOfField(string name)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).IndexOf(name);
        }

        public JsonField Find(Predicate<JsonField> match)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).Find(match);
        }

        public List<JsonField> FindAll(Predicate<JsonField> match)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).FindAll(match);
        }

        public int FindIndex(Predicate<JsonField> match)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).FindIndex(match);
        }

        public JsonField FindLast(Predicate<JsonField> match)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).FindLast(match);
        }

        public int FindLastIndex(Predicate<JsonField> match)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).FindLastIndex(match);
        }

        public bool Any(Func<JsonField, bool> predicate)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).Any(predicate);
        }

        public bool All(Func<JsonField, bool> predicate)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).All(predicate);
        }

        #region Get values
        public JsonValue GetValue(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetValue(fieldName);
        }

        public bool GetBool(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetBool(fieldName);
        }

        public byte GetByte(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetByte(fieldName);
        }

        public char GetChar(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetChar(fieldName);
        }

        public decimal GetDecimal(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetDecimal(fieldName);
        }

        public double GetDouble(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetDouble(fieldName);
        }

        public float GetFloat(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetFloat(fieldName);
        }

        public int GetInt(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetInt(fieldName);
        }

        public long GetLong(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetLong(fieldName);
        }

        public JsonNull GetNull(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetNull(fieldName);
        }

        public JsonNumber GetNumber(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetNumber(fieldName);
        }

        public sbyte GetSByte(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetSByte(fieldName);
        }

        public short GetShort(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetShort(fieldName);
        }

        public string GetString(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetString(fieldName);
        }

        public uint GetUInt(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetUInt(fieldName);
        }

        public ulong GetULong(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetULong(fieldName);
        }

        public ushort GetUShort(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetUShort(fieldName);
        }

        public JsonObject GetObject(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetObject(fieldName);
        }

        public JsonArray GetArray(string fieldName)
        {
            CheckCastTo<JsonObject>(string.Format("\"{0}\" can not be casted to \"JsonObject\"", _value.GetType().Name));

            return ((JsonObject)_value).GetArray(fieldName);
        }
        #endregion

        public void Replace(int index, JsonField field)
        {
            if (_value is JsonObject)
            {
                ((JsonObject)_value).Replace(index, field);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public void Replace(int index, string name, JsonValue value)
        {
            Replace(index, new JsonField(name, value));
        }

        public bool CheckNull(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).CheckNull(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }
        #endregion

        #region JsonArray
        public void Add(JsonValue value)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).Add(value);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public void AddRange(IEnumerable<JsonValue> values)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).AddRange(values);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public void Insert(int index, JsonValue value)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).Insert(index, value);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public void InsertRange(int index, IEnumerable<JsonValue> values)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).InsertRange(index, values);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public void InsertOrAppend(int index, JsonValue value)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).InsertOrAppend(index, value);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public bool RemoveValue(JsonValue value)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).Remove(value);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public int RemoveAll(Predicate<JsonValue> predicate)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).RemoveAll(predicate);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public bool Contains(JsonValue value)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).Contains(value);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public int IndexOfValue(JsonValue value)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).IndexOf(value);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public JsonValue Find(Predicate<JsonValue> match)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).Find(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public List<JsonValue> FindAll(Predicate<JsonValue> match)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).FindAll(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public int FindIndex(Predicate<JsonValue> match)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).FindIndex(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public JsonValue FindLast(Predicate<JsonValue> match)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).FindLast(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public int FindLastIndex(Predicate<JsonValue> match)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).FindLastIndex(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public bool Any(Func<JsonValue, bool> predicate)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).Any(predicate);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public bool All(Func<JsonValue, bool> predicate)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).All(predicate);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public void Replace(int index, JsonValue value)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value)[index] = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return _value.ToString();
        }
        #endregion

        #region Indexers
        public JsonWrap this[int index]
        {
            get
            {
                if (_value is JsonObject)
                {
                    return ((JsonObject)_value)[index];
                }

                if (_value is JsonArray)
                {
                    return ((JsonArray)_value)[index];
                }

                throw new JsonInvalidCastException(string.Format("\"{0}\" can not be casted to \"JsonObject\" or \"JsonArray\"", _value.GetType().Name));
            }
            set
            {
                if (_value is JsonObject)
                {
                    ((JsonObject)_value)[index] = value;
                }

                if (_value is JsonArray)
                {
                    ((JsonArray)_value)[index] = value;
                }

                throw new JsonInvalidCastException(string.Format("\"{0}\" can not be casted to \"JsonObject\" or \"JsonArray\"", _value.GetType().Name));
            }
        }

        public JsonWrap this[string fieldName]
        {
            get { return new JsonWrap(GetValue(fieldName)); }
            set { GetField(fieldName).Value = value; }
        }
        #endregion

        #region Events handlers
        #endregion
        #endregion
    }
}