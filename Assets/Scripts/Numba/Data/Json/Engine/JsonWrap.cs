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
            set { _value = value ?? new JsonNull(); }
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
        private JsonWrap() : this(new JsonNull()) { }

        public JsonWrap(JsonValue value)
        {
            SetWrappedValue(value);
        }
        #endregion

        #region Methods
        public void SetWrappedValue(JsonValue value)
        {
            _value = value ?? new JsonNull();
        }

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

        #region JsonNumber
        #region Set number
        public void SetNumber(byte number)
        {
            if (_value is JsonNumber)
            {
                ((JsonNumber)_value).SetNumber(number);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public void SetNumber(decimal number)
        {
            if (_value is JsonNumber)
            {
                ((JsonNumber)_value).SetNumber(number);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public void SetNumber(double number)
        {
            if (_value is JsonNumber)
            {
                ((JsonNumber)_value).SetNumber(number);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public void SetNumber(float number)
        {
            if (_value is JsonNumber)
            {
                ((JsonNumber)_value).SetNumber(number);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public void SetNumber(int number)
        {
            if (_value is JsonNumber)
            {
                ((JsonNumber)_value).SetNumber(number);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public void SetNumber(long number)
        {
            if (_value is JsonNumber)
            {
                ((JsonNumber)_value).SetNumber(number);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public void SetNumber(sbyte number)
        {
            if (_value is JsonNumber)
            {
                ((JsonNumber)_value).SetNumber(number);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public void SetNumber(short number)
        {
            if (_value is JsonNumber)
            {
                ((JsonNumber)_value).SetNumber(number);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public void SetNumber(uint number)
        {
            if (_value is JsonNumber)
            {
                ((JsonNumber)_value).SetNumber(number);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public void SetNumber(ulong number)
        {
            if (_value is JsonNumber)
            {
                ((JsonNumber)_value).SetNumber(number);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public void SetNumber(ushort number)
        {
            if (_value is JsonNumber)
            {
                ((JsonNumber)_value).SetNumber(number);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }
        #endregion

        public byte NumberToByte()
        {
            if (_value is JsonNumber)
            {
                return ((JsonNumber)_value).ToByte();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public decimal NumberToDecimal()
        {
            if (_value is JsonNumber)
            {
                return ((JsonNumber)_value).ToDecimal();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public double NumberToDouble()
        {
            if (_value is JsonNumber)
            {
                return ((JsonNumber)_value).ToDouble();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public float NumberToFloat()
        {
            if (_value is JsonNumber)
            {
                return ((JsonNumber)_value).ToFloat();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public int NumberToInt()
        {
            if (_value is JsonNumber)
            {
                return ((JsonNumber)_value).ToInt();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public long NumberToLong()
        {
            if (_value is JsonNumber)
            {
                return ((JsonNumber)_value).ToLong();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public sbyte NumberToSByte()
        {
            if (_value is JsonNumber)
            {
                return ((JsonNumber)_value).ToSByte();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public short NumberToShort()
        {
            if (_value is JsonNumber)
            {
                return ((JsonNumber)_value).ToShort();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public uint NumberToUInt()
        {
            if (_value is JsonNumber)
            {
                return ((JsonNumber)_value).ToUInt();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public ulong NumberToULong()
        {
            if (_value is JsonNumber)
            {
                return ((JsonNumber)_value).ToULong();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }

        public ushort NumberToUShort()
        {
            if (_value is JsonNumber)
            {
                return ((JsonNumber)_value).ToUShort();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonNumber\"", _value.GetType().Name));
        }
        #endregion

        public IEnumerator GetEnumerator()
        {
            if (_value is JsonObject || _value is JsonArray)
            {
                return ((IEnumerable)_value).GetEnumerator();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" does not implement \"IEnumerable\" or \"IEnumerable<T>\" interface", _value.GetType().Name));
        }

        #region JsonObject
        public void AddField(JsonField field)
        {
            if (_value is JsonObject)
            {
                ((JsonObject)_value).Add(field);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public void AddField(string name, JsonValue value)
        {
            AddField(new JsonField(name, value));
        }

        public void AddFields(IEnumerable<JsonField> fields)
        {
            if (_value is JsonObject)
            {
                ((JsonObject)_value).AddRange(fields);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public void InsertField(int index, JsonField field)
        {
            if (_value is JsonObject)
            {
                ((JsonObject)_value).Insert(index, field);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public void InsertField(int index, string name, JsonValue value)
        {
            InsertField(index, new JsonField(name, value));
        }

        public void InsertFields(int index, IEnumerable<JsonField> fields)
        {
            if (_value is JsonObject)
            {
                ((JsonObject)_value).InsertRange(index, fields);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public void InsertOrAppendField(int index, JsonField field)
        {
            if (_value is JsonObject)
            {
                ((JsonObject)_value).InsertOrAppend(index, field);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public void InsertOrAppendField(int index, string name, JsonValue value)
        {
            InsertOrAppendField(index, new JsonField(name, value));
        }

        public bool RemoveField(JsonField field)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).Remove(field);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public bool RemoveField(string name)
        {
            return RemoveField(GetField(name));
        }

        public void RemoveFieldAt(int index)
        {
            if (_value is JsonObject)
            {
                ((JsonObject)_value).RemoveAt(index);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public void RemoveFieldsRange(int index, int count)
        {
            if (_value is JsonObject)
            {
                ((JsonObject)_value).RemoveRange(index, count);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public int RemoveAllFields(Predicate<JsonField> match)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).RemoveAll(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public void ClearFields()
        {
            if (_value is JsonObject)
            {
                ((JsonObject)_value).Clear();
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public JsonField GetField(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetField(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public JsonField GetFieldAt(int index)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetFieldAt(index);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public bool HasField(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).HasField(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public bool ContainsField(JsonField field)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).Contains(field);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public int IndexOfField(JsonField field)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).IndexOf(field);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public int IndexOfField(string name)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).IndexOf(name);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public JsonField FindField(Predicate<JsonField> match)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).Find(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public List<JsonField> FindAllFields(Predicate<JsonField> match)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).FindAll(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public int FindFieldIndex(Predicate<JsonField> match)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).FindIndex(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public JsonField FindLastField(Predicate<JsonField> match)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).FindLast(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public int FindLastFieldIndex(Predicate<JsonField> match)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).FindLastIndex(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public bool AnyField(Func<JsonField, bool> predicate)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).Any(predicate);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public bool AllFields(Func<JsonField, bool> predicate)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).All(predicate);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        #region Get values
        public JsonValue GetFieldValue(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetValue(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public bool GetFieldBool(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetBool(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public byte GetFieldByte(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetByte(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public char GetFieldChar(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetChar(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public decimal GetFieldDecimal(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetDecimal(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public double GetFieldDouble(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetDouble(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public float GetFieldFloat(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetFloat(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public int GetFieldInt(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetInt(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public long GetFieldLong(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetLong(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public JsonNull GetFieldNull(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetNull(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public JsonNumber GetFieldNumber(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetNumber(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public sbyte GetFieldSByte(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetSByte(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public short GetFieldShort(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetShort(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public string GetFieldString(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetString(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public uint GetFieldUInt(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetUInt(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public ulong GetFieldULong(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetULong(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public ushort GetFieldUShort(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetUShort(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public JsonObject GetFieldObject(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetObject(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public JsonArray GetFieldArray(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).GetArray(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }
        #endregion

        public void ReplaceField(int index, JsonField field)
        {
            if (_value is JsonObject)
            {
                ((JsonObject)_value).Replace(index, field);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public void ReplaceField(int index, string name, JsonValue value)
        {
            ReplaceField(index, new JsonField(name, value));
        }

        public void SwapFields(int first, int second)
        {
            if (_value is JsonObject)
            {
                ((JsonObject)_value).SwapFields(first, second);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }

        public bool CheckFieldOnNull(string fieldName)
        {
            if (_value is JsonObject)
            {
                return ((JsonObject)_value).CheckOnNull(fieldName);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonObject\"", _value.GetType().Name));
        }
        #endregion

        #region JsonArray
        public void AddValue(JsonValue value)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).Add(value);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public void AddValues(IEnumerable<JsonValue> values)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).AddRange(values);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public void InsertValue(int index, JsonValue value)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).Insert(index, value);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public void InsertValues(int index, IEnumerable<JsonValue> values)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).InsertRange(index, values);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public void InsertOrAppendValue(int index, JsonValue value)
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

        public void RemoveValueAt(int index)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).RemoveAt(index);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public int RemoveAllValues(Predicate<JsonValue> predicate)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).RemoveAll(predicate);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public void RemoveValuesRange(int index, int count)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).RemoveRange(index, count);
                return;
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public void ClearValues()
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).Clear();
                return;
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

        public JsonValue FindValue(Predicate<JsonValue> match)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).Find(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public List<JsonValue> FindAllValues(Predicate<JsonValue> match)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).FindAll(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public int FindValueIndex(Predicate<JsonValue> match)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).FindIndex(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public JsonValue FindLastValue(Predicate<JsonValue> match)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).FindLast(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public int FindLastValueIndex(Predicate<JsonValue> match)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).FindLastIndex(match);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public bool AnyValue(Func<JsonValue, bool> predicate)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).Any(predicate);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public bool AllValues(Func<JsonValue, bool> predicate)
        {
            if (_value is JsonArray)
            {
                return ((JsonArray)_value).All(predicate);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public void SwapValues(int first, int second)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).SwapValues(first, second);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
        }

        public bool CheckOnNull(int index)
        {
            if (_value is JsonArray)
            {
                ((JsonArray)_value).CheckOnNull(index);
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"JsonArray\"", _value.GetType().Name));
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
            get { return new JsonWrap(((JsonArray)_value)[index]); }
            set { ((JsonArray)_value)[index] = value; }
        }

        public JsonWrap this[string fieldName]
        {
            get { return new JsonWrap(GetFieldValue(fieldName)); }
            set { GetField(fieldName).Value = value; }
        }
        #endregion

        #region Events handlers
        #endregion
        #endregion
    }
}