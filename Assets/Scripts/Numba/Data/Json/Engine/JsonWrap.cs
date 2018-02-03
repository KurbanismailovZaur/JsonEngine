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

        public JsonTypeCategory Category { get { return _value.Category; } }

        public JsonDataType Type { get { return _value.Type; } }
        #endregion

        #region Constructors
        public JsonWrap(JsonValue value)
        {
            _value = value ?? JsonNull.value;
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

        #region As
        public bool AsBool()
        {
            return ((JsonBool)_value).Value;
        }

        public byte AsByte()
        {
            return ((JsonByte)_value).Value;
        }

        public char AsChar()
        {
            return ((JsonChar)_value).Value;
        }

        public decimal AsDecimal()
        {
            return ((JsonDecimal)_value).Value;
        }

        public double AsDouble()
        {
            return ((JsonDouble)_value).Value;
        }

        public float AsFloat()
        {
            return ((JsonFloat)_value).Value;
        }

        public int AsInt()
        {
            return ((JsonInt)_value).Value;
        }

        public long AsLong()
        {
            return ((JsonLong)_value).Value;
        }

        public JsonNull AsNull()
        {
            return ((JsonNull)_value);
        }

        public JsonNumber AsNumber()
        {
            return ((JsonNumber)_value);
        }

        public SByte AsSByte()
        {
            return ((JsonSByte)_value).Value;
        }

        public short AsShort()
        {
            return ((JsonShort)_value).Value;
        }

        public string AsString()
        {
            return ((JsonString)_value).Value;
        }

        public uint AsUInt()
        {
            return ((JsonUInt)_value).Value;
        }

        public ulong AsULong()
        {
            return ((JsonULong)_value).Value;
        }

        public ushort AsUShort()
        {
            return ((JsonUShort)_value).Value;
        }

        public JsonObject AsObject()
        {
            return ((JsonObject)_value);
        }

        public JsonArray AsArray()
        {
            return ((JsonArray)_value);
        }
        #endregion

        private void CastToAndInvoke<T>(Action action)
        {
            if (!(_value is T))
            {
                throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"{1}\"", _value.GetType().Name, typeof(T).Name));
            }

            action.Invoke();
        }

        private T2 CastToAndInvoke<T1, T2>(Func<T2> func)
        {
            if (!(_value is T1))
            {
                throw new JsonInvalidCastException(string.Format("\"{0}\" can not cast to \"{1}\"", _value.GetType().Name, typeof(T1).Name));
            }

            return func.Invoke();
        }

        private void CastToObjectOrArrayAndInvoke(Action objectAction, Action arrayAction)
        {
            if (_value is JsonObject)
            {
                objectAction.Invoke();
                return;
            }

            if (_value is JsonArray)
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

            if (_value is JsonArray)
            {
                return arrayFunc.Invoke();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" can not be casted to \"JsonObject\" or \"JsonArray\"", _value.GetType().Name));
        }

        #region JsonNumber
        #region Set number
        public void SetNumber(JsonNumber number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        public void SetNumber(byte number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        public void SetNumber(decimal number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        public void SetNumber(double number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        public void SetNumber(float number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        public void SetNumber(int number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        public void SetNumber(long number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        public void SetNumber(sbyte number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        public void SetNumber(short number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        public void SetNumber(uint number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        public void SetNumber(ulong number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        public void SetNumber(ushort number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }
        #endregion

        public byte NumberToByte()
        {
            return CastToAndInvoke<JsonNumber, byte>(() => { return ((JsonNumber)_value).ToByte(); });
        }

        public decimal NumberToDecimal()
        {
            return CastToAndInvoke<JsonNumber, decimal>(() => { return ((JsonNumber)_value).ToDecimal(); });
        }

        public double NumberToDouble()
        {
            return CastToAndInvoke<JsonNumber, double>(() => { return ((JsonNumber)_value).ToDouble(); });
        }

        public float NumberToFloat()
        {
            return CastToAndInvoke<JsonNumber, float>(() => { return ((JsonNumber)_value).ToFloat(); });
        }

        public int NumberToInt()
        {
            return CastToAndInvoke<JsonNumber, int>(() => { return ((JsonNumber)_value).ToInt(); });
        }

        public long NumberToLong()
        {
            return CastToAndInvoke<JsonNumber, long>(() => { return ((JsonNumber)_value).ToLong(); });
        }

        public sbyte NumberToSByte()
        {
            return CastToAndInvoke<JsonNumber, sbyte>(() => { return ((JsonNumber)_value).ToSByte(); });
        }

        public short NumberToShort()
        {
            return CastToAndInvoke<JsonNumber, short>(() => { return ((JsonNumber)_value).ToShort(); });
        }

        public uint NumberToUInt()
        {
            return CastToAndInvoke<JsonNumber, uint>(() => { return ((JsonNumber)_value).ToUInt(); });
        }

        public ulong NumberToULong()
        {
            return CastToAndInvoke<JsonNumber, ulong>(() => { return ((JsonNumber)_value).ToULong(); });
        }

        public ushort NumberToUShort()
        {
            return CastToAndInvoke<JsonNumber, ushort>(() => { return ((JsonNumber)_value).ToUShort(); });
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
        public int FieldsCount
        {
            get
            {
                return CastToAndInvoke<JsonObject, int>(() => ((JsonObject)_value).Count);
            }
        }

        public void AddField(JsonField field)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).Add(field); });
        }

        public void AddField(string name, JsonValue value)
        {
            AddField(new JsonField(name, value));
        }

        public void AddFieldsRange(IEnumerable<JsonField> fields)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).AddRange(fields); });
        }

        public void InsertField(int index, JsonField field)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).Insert(index, field); });
        }

        public void InsertField(int index, string name, JsonValue value)
        {
            InsertField(index, new JsonField(name, value));
        }

        public void InsertFieldsRange(int index, IEnumerable<JsonField> fields)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).InsertRange(index, fields); });
        }

        public void InsertOrAppendField(int index, JsonField field)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).InsertOrAppend(index, field); });
        }

        public void InsertOrAppendField(int index, string name, JsonValue value)
        {
            InsertOrAppendField(index, new JsonField(name, value));
        }

        public bool RemoveField(JsonField field)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).Remove(field); });
        }

        public bool RemoveField(string fieldName)
        {
            return RemoveField(GetField(fieldName));
        }

        public void RemoveFieldAt(int index)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).RemoveAt(index); });
        }

        public void RemoveFieldsRange(int index, int count)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).RemoveRange(index, count); });
        }

        public int RemoveAllFields(Predicate<JsonField> match)
        {
            return CastToAndInvoke<JsonObject, int>(() => { return ((JsonObject)_value).RemoveAll(match); });
        }

        public JsonField GetField(string fieldName)
        {
            return CastToAndInvoke<JsonObject, JsonField>(() => { return ((JsonObject)_value).GetField(fieldName); });
        }

        public JsonField GetFieldAt(int index)
        {
            return CastToAndInvoke<JsonObject, JsonField>(() => { return ((JsonObject)_value).GetFieldAt(index); });
        }

        public bool HasFieldWithNane(string fieldName)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).HasFieldWithName(fieldName); });
        }

        public bool ContainsField(JsonField field)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).Contains(field); });
        }

        public int IndexOfField(JsonField field)
        {
            return CastToAndInvoke<JsonObject, int>(() => { return ((JsonObject)_value).IndexOf(field); });
        }

        public int IndexOfField(string name)
        {
            return CastToAndInvoke<JsonObject, int>(() => { return ((JsonObject)_value).IndexOf(name); });
        }

        public JsonField FindField(Predicate<JsonField> match)
        {
            return CastToAndInvoke<JsonObject, JsonField>(() => { return ((JsonObject)_value).Find(match); });
        }

        public List<JsonField> FindAllFields(Predicate<JsonField> match)
        {
            return CastToAndInvoke<JsonObject, List<JsonField>>(() => { return ((JsonObject)_value).FindAll(match); });
        }

        public int FindFieldIndex(Predicate<JsonField> match)
        {
            return CastToAndInvoke<JsonObject, int>(() => { return ((JsonObject)_value).FindIndex(match); });
        }

        public JsonField FindLastField(Predicate<JsonField> match)
        {
            return CastToAndInvoke<JsonObject, JsonField>(() => { return ((JsonObject)_value).FindLast(match); });
        }

        public int FindLastFieldIndex(Predicate<JsonField> match)
        {
            return CastToAndInvoke<JsonObject, int>(() => { return ((JsonObject)_value).FindLastIndex(match); });
        }

        public bool AnyField(Func<JsonField, bool> predicate)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).Any(predicate); });
        }

        public bool AllFields(Func<JsonField, bool> predicate)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).All(predicate); });
        }

        public void SwapFields(int first, int second)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).SwapFields(first, second); });
        }

        public void SwapFields(string first, string second)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).SwapFields(first, second); });
        }

        public bool CheckFieldNull(int index)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).CheckNull(index); });
        }

        public bool CheckFieldNull(string fieldName)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).CheckNull(fieldName); });
        }

        #region Get values
        public JsonValue GetFieldValue(string fieldName)
        {
            return CastToAndInvoke<JsonObject, JsonValue>(() => { return ((JsonObject)_value).GetValue(fieldName); });
        }

        public JsonValue GetFieldValue(int index)
        {
            return CastToAndInvoke<JsonObject, JsonValue>(() => { return ((JsonObject)_value).GetValue(index); });
        }

        public bool GetFieldBool(string fieldName)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).GetBool(fieldName); });
        }

        public bool GetFieldBool(int index)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).GetBool(index); });
        }

        public byte GetFieldByte(string fieldName)
        {
            return CastToAndInvoke<JsonObject, byte>(() => { return ((JsonObject)_value).GetByte(fieldName); });
        }

        public byte GetFieldByte(int index)
        {
            return CastToAndInvoke<JsonByte, byte>(() => { return ((JsonObject)_value).GetByte(index); });
        }

        public char GetFieldChar(string fieldName)
        {
            return CastToAndInvoke<JsonObject, char>(() => { return ((JsonObject)_value).GetChar(fieldName); });
        }

        public char GetFieldChar(int index)
        {
            return CastToAndInvoke<JsonChar, char>(() => { return ((JsonObject)_value).GetChar(index); });
        }

        public decimal GetFieldDecimal(string fieldName)
        {
            return CastToAndInvoke<JsonObject, decimal>(() => { return ((JsonObject)_value).GetDecimal(fieldName); });
        }

        public decimal GetFieldDecimal(int index)
        {
            return CastToAndInvoke<JsonDecimal, decimal>(() => { return ((JsonObject)_value).GetDecimal(index); });
        }

        public double GetFieldDouble(string fieldName)
        {
            return CastToAndInvoke<JsonObject, double>(() => { return ((JsonObject)_value).GetDouble(fieldName); });
        }

        public double GetFieldDouble(int index)
        {
            return CastToAndInvoke<JsonDouble, double>(() => { return ((JsonObject)_value).GetDouble(index); });
        }

        public float GetFieldFloat(string fieldName)
        {
            return CastToAndInvoke<JsonObject, float>(() => { return ((JsonObject)_value).GetFloat(fieldName); });
        }

        public float GetFieldFloat(int index)
        {
            return CastToAndInvoke<JsonFloat, float>(() => { return ((JsonObject)_value).GetFloat(index); });
        }

        public int GetFieldInt(string fieldName)
        {
            return CastToAndInvoke<JsonObject, int>(() => { return ((JsonObject)_value).GetInt(fieldName); });
        }

        public int GetFieldInt(int index)
        {
            return CastToAndInvoke<JsonInt, int>(() => { return ((JsonObject)_value).GetInt(index); });
        }

        public long GetFieldLong(string fieldName)
        {
            return CastToAndInvoke<JsonObject, long>(() => { return ((JsonObject)_value).GetLong(fieldName); });
        }

        public long GetFieldLong(int index)
        {
            return CastToAndInvoke<JsonLong, long>(() => { return ((JsonObject)_value).GetLong(index); });
        }

        public JsonNull GetFieldNull(string fieldName)
        {
            return CastToAndInvoke<JsonObject, JsonNull>(() => { return ((JsonObject)_value).GetNull(fieldName); });
        }

        public JsonNull GetFieldNull(int index)
        {
            return CastToAndInvoke<JsonNull, JsonNull>(() => { return ((JsonObject)_value).GetNull(index); });
        }

        public JsonNumber GetFieldNumber(string fieldName)
        {
            return CastToAndInvoke<JsonObject, JsonNumber>(() => { return ((JsonObject)_value).GetNumber(fieldName); });
        }

        public JsonNumber GetFieldNumber(int index)
        {
            return CastToAndInvoke<JsonNumber, JsonNumber>(() => { return ((JsonObject)_value).GetNumber(index); });
        }

        public sbyte GetFieldSByte(string fieldName)
        {
            return CastToAndInvoke<JsonObject, sbyte>(() => { return ((JsonObject)_value).GetSByte(fieldName); });
        }

        public sbyte GetFieldSByte(int index)
        {
            return CastToAndInvoke<JsonSByte, sbyte>(() => { return ((JsonObject)_value).GetSByte(index); });
        }

        public short GetFieldShort(string fieldName)
        {
            return CastToAndInvoke<JsonObject, short>(() => { return ((JsonObject)_value).GetShort(fieldName); });
        }

        public short GetFieldShort(int index)
        {
            return CastToAndInvoke<JsonShort, short>(() => { return ((JsonObject)_value).GetShort(index); });
        }

        public string GetFieldString(string fieldName)
        {
            return CastToAndInvoke<JsonObject, string>(() => { return ((JsonObject)_value).GetString(fieldName); });
        }

        public string GetFieldString(int index)
        {
            return CastToAndInvoke<JsonString, string>(() => { return ((JsonObject)_value).GetString(index); });
        }

        public uint GetFieldUInt(string fieldName)
        {
            return CastToAndInvoke<JsonObject, uint>(() => { return ((JsonObject)_value).GetUInt(fieldName); });
        }

        public uint GetFieldUInt(int index)
        {
            return CastToAndInvoke<JsonUInt, uint>(() => { return ((JsonObject)_value).GetUInt(index); });
        }

        public ulong GetFieldULong(string fieldName)
        {
            return CastToAndInvoke<JsonObject, ulong>(() => { return ((JsonObject)_value).GetULong(fieldName); });
        }

        public ulong GetFieldULong(int index)
        {
            return CastToAndInvoke<JsonULong, ulong>(() => { return ((JsonObject)_value).GetULong(index); });
        }

        public ushort GetFieldUShort(string fieldName)
        {
            return CastToAndInvoke<JsonObject, ushort>(() => { return ((JsonObject)_value).GetUShort(fieldName); });
        }

        public ushort GetFieldUShort(int index)
        {
            return CastToAndInvoke<JsonUShort, ushort>(() => { return ((JsonObject)_value).GetUShort(index); });
        }

        public JsonObject GetFieldObject(string fieldName)
        {
            return CastToAndInvoke<JsonObject, JsonObject>(() => { return ((JsonObject)_value).GetObject(fieldName); });
        }

        public JsonObject GetFieldObject(int index)
        {
            return CastToAndInvoke<JsonObject, JsonObject>(() => { return ((JsonObject)_value).GetObject(index); });
        }

        public JsonArray GetFieldArray(string fieldName)
        {
            return CastToAndInvoke<JsonObject, JsonArray>(() => { return ((JsonObject)_value).GetArray(fieldName); });
        }

        public JsonArray GetFieldArray(int index)
        {
            return CastToAndInvoke<JsonArray, JsonArray>(() => { return ((JsonObject)_value).GetArray(index); });
        }
        #endregion

        public void ReplaceField(int index, JsonField field)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).Replace(index, field); });
        }

        public void ReplaceField(int index, string name, JsonValue value)
        {
            ReplaceField(index, new JsonField(name, value));
        }

        public void ClearFields()
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).Clear(); });
        }
        #endregion

        #region JsonArray
        public int ValuesCount
        {
            get
            {
                return CastToAndInvoke<JsonArray, int>(() => ((JsonArray)_value).Count);
            }
        }

        public void AddValue(JsonValue value)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).Add(value); });
        }

        public void AddValuesRange(IEnumerable<JsonValue> values)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).AddRange(values); });
        }

        public void InsertValue(int index, JsonValue value)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).Insert(index, value); });
        }

        public void InsertValueRange(int index, IEnumerable<JsonValue> values)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).InsertRange(index, values); });
        }

        public void InsertOrAppendValue(int index, JsonValue value)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).InsertOrAppend(index, value); });
        }

        public bool RemoveValue(JsonValue value)
        {
            return CastToAndInvoke<JsonArray, bool>(() => { return ((JsonArray)_value).Remove(value); });
        }

        public void RemoveValueAt(int index)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).RemoveAt(index); });
        }

        public void RemoveValuesRange(int index, int count)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).RemoveRange(index, count); });
        }

        public int RemoveAllValues(Predicate<JsonValue> predicate)
        {
            return CastToAndInvoke<JsonArray, int>(() => { return ((JsonArray)_value).RemoveAll(predicate); });
        }

        public bool ContainsValue(JsonValue value)
        {
            return CastToAndInvoke<JsonArray, bool>(() => { return ((JsonArray)_value).Contains(value); });
        }

        public int IndexOfValue(JsonValue value)
        {
            return CastToAndInvoke<JsonArray, int>(() => { return ((JsonArray)_value).IndexOf(value); });
        }

        public JsonValue FindValue(Predicate<JsonValue> match)
        {
            return CastToAndInvoke<JsonArray, JsonValue>(() => { return ((JsonArray)_value).Find(match); });
        }

        public List<JsonValue> FindAllValues(Predicate<JsonValue> match)
        {
            return CastToAndInvoke<JsonArray, List<JsonValue>>(() => { return ((JsonArray)_value).FindAll(match); });
        }

        public int FindValueIndex(Predicate<JsonValue> match)
        {
            return CastToAndInvoke<JsonArray, int>(() => { return ((JsonArray)_value).FindIndex(match); });
        }

        public JsonValue FindLastValue(Predicate<JsonValue> match)
        {
            return CastToAndInvoke<JsonArray, JsonValue>(() => { return ((JsonArray)_value).FindLast(match); });
        }

        public int FindLastValueIndex(Predicate<JsonValue> match)
        {
            return CastToAndInvoke<JsonArray, int>(() => { return ((JsonArray)_value).FindLastIndex(match); });
        }

        public bool AnyValue(Func<JsonValue, bool> predicate)
        {
            return CastToAndInvoke<JsonArray, bool>(() => { return ((JsonArray)_value).Any(predicate); });
        }

        public bool AllValues(Func<JsonValue, bool> predicate)
        {
            return CastToAndInvoke<JsonArray, bool>(() => { return ((JsonArray)_value).All(predicate); });
        }

        public void ReplaceValue(int index, JsonValue value)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value)[index] = value; });
        }

        public void SwapValues(int first, int second)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).SwapValues(first, second); });
        }

        public bool CheckValueNull(int index)
        {
            return CastToAndInvoke<JsonArray, bool>(() => { return ((JsonArray)_value).CheckNull(index); });
        }

        #region Get values
        public JsonValue GetValue(int index)
        {
            return CastToAndInvoke<JsonArray, JsonValue>(() => { return ((JsonArray)_value)[index]; });
        }

        public bool GetBool(int index)
        {
            return CastToAndInvoke<JsonArray, bool>(() => { return ((JsonBool)((JsonArray)_value)[index]).Value; });
        }

        public byte GetByte(int index)
        {
            return CastToAndInvoke<JsonArray, byte>(() => { return ((JsonByte)((JsonArray)_value)[index]).Value; });
        }

        public char GetChar(int index)
        {
            return CastToAndInvoke<JsonArray, char>(() => { return ((JsonChar)((JsonArray)_value)[index]).Value; });
        }

        public decimal GetDecimal(int index)
        {
            return CastToAndInvoke<JsonArray, decimal>(() => { return ((JsonDecimal)((JsonArray)_value)[index]).Value; });
        }

        public double GetDouble(int index)
        {
            return CastToAndInvoke<JsonArray, double>(() => { return ((JsonDouble)((JsonArray)_value)[index]).Value; });
        }

        public float GetFloat(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetFloat(index); }, () => { return ((JsonArray)_value).GetFloat(index); });
        }

        public int GetInt(int index)
        {
            return CastToAndInvoke<JsonArray, int>(() => { return ((JsonInt)((JsonArray)_value)[index]).Value; });
        }

        public long GetLong(int index)
        {
            return CastToAndInvoke<JsonArray, long>(() => { return ((JsonLong)((JsonArray)_value)[index]).Value; });
        }

        public JsonNull GetNull(int index)
        {
            return CastToAndInvoke<JsonArray, JsonNull>(() => { return ((JsonNull)((JsonArray)_value)[index]); });
        }

        public JsonNumber GetNumber(int index)
        {
            return CastToAndInvoke<JsonArray, JsonNumber>(() => { return ((JsonNumber)((JsonArray)_value)[index]); });
        }

        public sbyte GetSByte(int index)
        {
            return CastToAndInvoke<JsonArray, sbyte>(() => { return ((JsonSByte)((JsonArray)_value)[index]).Value; });
        }

        public short GetShort(int index)
        {
            return CastToAndInvoke<JsonArray, short>(() => { return ((JsonShort)((JsonArray)_value)[index]).Value; });
        }

        public string GetString(int index)
        {
            return CastToAndInvoke<JsonArray, string>(() => { return ((JsonString)((JsonArray)_value)[index]).Value; });
        }

        public uint GetUInt(int index)
        {
            return CastToAndInvoke<JsonArray, uint>(() => { return ((JsonUInt)((JsonArray)_value)[index]).Value; });
        }

        public ulong GetULong(int index)
        {
            return CastToAndInvoke<JsonArray, ulong>(() => { return ((JsonULong)((JsonArray)_value)[index]).Value; });
        }

        public ushort GetUShort(int index)
        {
            return CastToAndInvoke<JsonArray, ushort>(() => { return ((JsonUShort)((JsonArray)_value)[index]).Value; });
        }

        public JsonObject GetObject(int index)
        {
            return CastToAndInvoke<JsonArray, JsonObject>(() => { return ((JsonObject)((JsonArray)_value)[index]); });
        }

        public JsonArray GetArray(int index)
        {
            return CastToAndInvoke<JsonArray, JsonArray>(() => { return ((JsonArray)((JsonArray)_value)[index]); });
        }
        #endregion

        public void ClearValues()
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).Clear(); });
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
                return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value)[index]; }, () => { return ((JsonArray)_value)[index]; });
            }
            set
            {
                CastToObjectOrArrayAndInvoke(() => { ((JsonObject)_value)[index] = value; }, () => { ((JsonArray)_value)[index] = value; });
            }
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