using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    /// <summary>
    /// Wrapper class for any class derived from JsonValue or system primitive types.
    /// </summary>
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
        /// <summary>
        /// Wrapped value.
        /// </summary>
        public JsonValue Value
        {
            get { return _value; }
            set { _value = value ?? JsonNull.value; }
        }

        /// <summary>
        /// Returns category for wrapped object.
        /// </summary>
        public JsonTypeCategory Category { get { return _value.Category; } }

        /// <summary>
        /// Returns type for wrapped object.
        /// </summary>
        public JsonDataType Type { get { return _value.Type; } }
        #endregion

        #region Constructors
        /// <summary>
        /// Create JsonWrap and initialize it with value.
        /// </summary>
        /// <param name="value"></param>
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
        /// <summary>
        /// return casted to bool wrapped value.
        /// </summary>
        /// <returns>Casted to bool wrapped value.</returns>
        public bool AsBool()
        {
            return ((JsonBool)_value).Value;
        }

        /// <summary>
        /// return casted to byte wrapped value.
        /// </summary>
        /// <returns>Casted to byte wrapped value.</returns>
        public byte AsByte()
        {
            return ((JsonByte)_value).Value;
        }

        /// <summary>
        /// return casted to char wrapped value.
        /// </summary>
        /// <returns>Casted to char wrapped value.</returns>
        public char AsChar()
        {
            return ((JsonChar)_value).Value;
        }

        /// <summary>
        /// return casted to decimal wrapped value.
        /// </summary>
        /// <returns>Casted to decimal wrapped value.</returns>
        public decimal AsDecimal()
        {
            return ((JsonDecimal)_value).Value;
        }

        /// <summary>
        /// return casted to double wrapped value.
        /// </summary>
        /// <returns>Casted to double wrapped value.</returns>
        public double AsDouble()
        {
            return ((JsonDouble)_value).Value;
        }

        /// <summary>
        /// return casted to float wrapped value.
        /// </summary>
        /// <returns>Casted to float wrapped value.</returns>
        public float AsFloat()
        {
            return ((JsonFloat)_value).Value;
        }

        /// <summary>
        /// return casted to int wrapped value.
        /// </summary>
        /// <returns>Casted to int wrapped value.</returns>
        public int AsInt()
        {
            return ((JsonInt)_value).Value;
        }

        /// <summary>
        /// return casted to long wrapped value.
        /// </summary>
        /// <returns>Casted to long wrapped value.</returns>
        public long AsLong()
        {
            return ((JsonLong)_value).Value;
        }

        /// <summary>
        /// return casted to JsonNull wrapped value.
        /// </summary>
        /// <returns>Casted to JsonNull wrapped value.</returns>
        public JsonNull AsNull()
        {
            return ((JsonNull)_value);
        }

        /// <summary>
        /// return casted to JsonNumber wrapped value.
        /// </summary>
        /// <returns>Casted to JsonNumber wrapped value.</returns>
        public JsonNumber AsNumber()
        {
            return ((JsonNumber)_value);
        }

        /// <summary>
        /// return casted to sbyte wrapped value.
        /// </summary>
        /// <returns>Casted to sbyte wrapped value.</returns>
        public SByte AsSByte()
        {
            return ((JsonSByte)_value).Value;
        }

        /// <summary>
        /// return casted to short wrapped value.
        /// </summary>
        /// <returns>Casted to short wrapped value.</returns>
        public short AsShort()
        {
            return ((JsonShort)_value).Value;
        }

        /// <summary>
        /// return casted to string wrapped value.
        /// </summary>
        /// <returns>Casted to string wrapped value.</returns>
        public string AsString()
        {
            return ((JsonString)_value).Value;
        }

        /// <summary>
        /// return casted to uint wrapped value.
        /// </summary>
        /// <returns>Casted to uint wrapped value.</returns>
        public uint AsUInt()
        {
            return ((JsonUInt)_value).Value;
        }

        /// <summary>
        /// return casted to ulong wrapped value.
        /// </summary>
        /// <returns>Casted to ulong wrapped value.</returns>
        public ulong AsULong()
        {
            return ((JsonULong)_value).Value;
        }

        /// <summary>
        /// return casted to ushort wrapped value.
        /// </summary>
        /// <returns>Casted to ushort wrapped value.</returns>
        public ushort AsUShort()
        {
            return ((JsonUShort)_value).Value;
        }

        /// <summary>
        /// return casted to JsonObject wrapped value.
        /// </summary>
        /// <returns>Casted to JsonObject wrapped value.</returns>
        public JsonObject AsObject()
        {
            return ((JsonObject)_value);
        }

        /// <summary>
        /// return casted to JsonArray wrapped value.
        /// </summary>
        /// <returns>Casted to JsonArray wrapped value.</returns>
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
        /// <summary>
        /// Set number to wrapped JsonNumber value.
        /// </summary>
        /// <param name="number">Number to set.</param>
        public void SetNumber(JsonNumber number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        /// <summary>
        /// Set number to wrapped JsonNumber value.
        /// </summary>
        /// <param name="number">Number to set.</param>
        public void SetNumber(byte number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        /// <summary>
        /// Set number to wrapped JsonNumber value.
        /// </summary>
        /// <param name="number">Number to set.</param>
        public void SetNumber(decimal number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        /// <summary>
        /// Set number to wrapped JsonNumber value.
        /// </summary>
        /// <param name="number">Number to set.</param>
        public void SetNumber(double number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        /// <summary>
        /// Set number to wrapped JsonNumber value.
        /// </summary>
        /// <param name="number">Number to set.</param>
        public void SetNumber(float number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        /// <summary>
        /// Set number to wrapped JsonNumber value.
        /// </summary>
        /// <param name="number">Number to set.</param>
        public void SetNumber(int number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        /// <summary>
        /// Set number to wrapped JsonNumber value.
        /// </summary>
        /// <param name="number">Number to set.</param>
        public void SetNumber(long number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        /// <summary>
        /// Set number to wrapped JsonNumber value.
        /// </summary>
        /// <param name="number">Number to set.</param>
        public void SetNumber(sbyte number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        /// <summary>
        /// Set number to wrapped JsonNumber value.
        /// </summary>
        /// <param name="number">Number to set.</param>
        public void SetNumber(short number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        /// <summary>
        /// Set number to wrapped JsonNumber value.
        /// </summary>
        /// <param name="number">Number to set.</param>
        public void SetNumber(uint number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        /// <summary>
        /// Set number to wrapped JsonNumber value.
        /// </summary>
        /// <param name="number">Number to set.</param>
        public void SetNumber(ulong number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }

        /// <summary>
        /// Set number to wrapped JsonNumber value.
        /// </summary>
        /// <param name="number">Number to set.</param>
        public void SetNumber(ushort number)
        {
            CastToAndInvoke<JsonNumber>(() => { ((JsonNumber)_value).SetNumber(number); });
        }
        #endregion

        /// <summary>
        /// Cast wrapped value to JsonNumber and then parse value as byte.
        /// </summary>
        /// <returns>Number parsed as byte.</returns>
        public byte NumberToByte()
        {
            return CastToAndInvoke<JsonNumber, byte>(() => { return ((JsonNumber)_value).ToByte(); });
        }

        /// <summary>
        /// Cast wrapped value to JsonNumber and then parse value as decimal.
        /// </summary>
        /// <returns>Number parsed as decimal.</returns>
        public decimal NumberToDecimal()
        {
            return CastToAndInvoke<JsonNumber, decimal>(() => { return ((JsonNumber)_value).ToDecimal(); });
        }

        /// <summary>
        /// Cast wrapped value to JsonNumber and then parse value as double.
        /// </summary>
        /// <returns>Number parsed as double.</returns>
        public double NumberToDouble()
        {
            return CastToAndInvoke<JsonNumber, double>(() => { return ((JsonNumber)_value).ToDouble(); });
        }

        /// <summary>
        /// Cast wrapped value to JsonNumber and then parse value as float.
        /// </summary>
        /// <returns>Number parsed as float.</returns>
        public float NumberToFloat()
        {
            return CastToAndInvoke<JsonNumber, float>(() => { return ((JsonNumber)_value).ToFloat(); });
        }

        /// <summary>
        /// Cast wrapped value to JsonNumber and then parse value as int.
        /// </summary>
        /// <returns>Number parsed as int.</returns>
        public int NumberToInt()
        {
            return CastToAndInvoke<JsonNumber, int>(() => { return ((JsonNumber)_value).ToInt(); });
        }

        /// <summary>
        /// Cast wrapped value to JsonNumber and then parse value as long.
        /// </summary>
        /// <returns>Number parsed as long.</returns>
        public long NumberToLong()
        {
            return CastToAndInvoke<JsonNumber, long>(() => { return ((JsonNumber)_value).ToLong(); });
        }

        /// <summary>
        /// Cast wrapped value to JsonNumber and then parse value as sbyte.
        /// </summary>
        /// <returns>Number parsed as sbyte.</returns>
        public sbyte NumberToSByte()
        {
            return CastToAndInvoke<JsonNumber, sbyte>(() => { return ((JsonNumber)_value).ToSByte(); });
        }

        /// <summary>
        /// Cast wrapped value to JsonNumber and then parse value as short.
        /// </summary>
        /// <returns>Number parsed as short.</returns>
        public short NumberToShort()
        {
            return CastToAndInvoke<JsonNumber, short>(() => { return ((JsonNumber)_value).ToShort(); });
        }

        /// <summary>
        /// Cast wrapped value to JsonNumber and then parse value as uint.
        /// </summary>
        /// <returns>Number parsed as uint.</returns>
        public uint NumberToUInt()
        {
            return CastToAndInvoke<JsonNumber, uint>(() => { return ((JsonNumber)_value).ToUInt(); });
        }

        /// <summary>
        /// Cast wrapped value to JsonNumber and then parse value as ulong.
        /// </summary>
        /// <returns>Number parsed as ulong.</returns>
        public ulong NumberToULong()
        {
            return CastToAndInvoke<JsonNumber, ulong>(() => { return ((JsonNumber)_value).ToULong(); });
        }

        /// <summary>
        /// Cast wrapped value to JsonNumber and then parse value as ushort.
        /// </summary>
        /// <returns>Number parsed as ushort.</returns>
        public ushort NumberToUShort()
        {
            return CastToAndInvoke<JsonNumber, ushort>(() => { return ((JsonNumber)_value).ToUShort(); });
        }
        #endregion

        /// <summary>
        /// Get fields (if wrapped value is JsonObject) or JsonValue's (if wrapped value is JsonArray) enumerator for JsonObject or JsonArray.
        /// </summary>
        /// <returns>Object enumerator.</returns>
        public IEnumerator GetEnumerator()
        {
            if (_value is JsonObject || _value is JsonArray)
            {
                return ((IEnumerable)_value).GetEnumerator();
            }

            throw new JsonInvalidCastException(string.Format("\"{0}\" does not implement \"IEnumerable\" or \"IEnumerable<T>\" interface", _value.GetType().Name));
        }

        #region JsonObject
        /// <summary>
        /// Count of fields.
        /// </summary>
        public int FieldsCount
        {
            get
            {
                return CastToAndInvoke<JsonObject, int>(() => ((JsonObject)_value).Count);
            }
        }

        /// <summary>
        /// Add field to end.
        /// </summary>
        /// <param name="field">Field to add.</param>
        public void AddField(JsonField field)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).Add(field); });
        }

        /// <summary>
        /// Create and add fields to end.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void AddField(string name, JsonValue value)
        {
            AddField(new JsonField(name, value));
        }

        /// <summary>
        /// Add fields to end.
        /// </summary>
        /// <param name="fields"></param>
        public void AddFieldsRange(IEnumerable<JsonField> fields)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).AddRange(fields); });
        }

        /// <summary>
        /// Insert field at specific position.
        /// </summary>
        /// <param name="index">Index to insert.</param>
        /// <param name="field">Field to insert.</param>
        public void InsertField(int index, JsonField field)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).Insert(index, field); });
        }

        /// <summary>
        /// Create and insert field at specific position.
        /// </summary>
        /// <param name="index">Index on which insert field.</param>
        /// <param name="name">Field name.</param>
        /// <param name="value">Field value.</param>
        public void InsertField(int index, string name, JsonValue value)
        {
            InsertField(index, new JsonField(name, value));
        }

        /// <summary>
        /// Insert fields start at specific position.
        /// </summary>
        /// <param name="index">Index on which insert fields.</param>
        /// <param name="fields">Fields enumerable.</param>
        public void InsertFieldsRange(int index, IEnumerable<JsonField> fields)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).InsertRange(index, fields); });
        }

        /// <summary>
        /// Insert field at specific position if index less or equal than fields count, otherwise add field to end.
        /// </summary>
        /// <param name="index">Index on which insert field if it less or equal than fields count.</param>
        /// <param name="field">Field to insert or add.</param>
        public void InsertOrAppendField(int index, JsonField field)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).InsertOrAppend(index, field); });
        }

        /// <summary>
        /// Create and insert field at specific position if index less or equal than fields count, otherwise add field to end.
        /// </summary>
        /// <param name="index">Index on which insert field if it less or equal than fields count.</param>
        /// <param name="name">Field name.</param>
        /// <param name="value">Field value.</param>
        public void InsertOrAppendField(int index, string name, JsonValue value)
        {
            InsertOrAppendField(index, new JsonField(name, value));
        }

        /// <summary>
        /// Remove field.
        /// </summary>
        /// <param name="field">Field to remove.</param>
        /// <returns>True if JsonField removed, otherwise false.</returns>
        public bool RemoveField(JsonField field)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).Remove(field); });
        }

        /// <summary>
        /// Remove field by name.
        /// </summary>
        /// <param name="name">Field name to remove.</param>
        /// <returns>True if JsonField removed, otherwise false.</returns>
        public bool RemoveField(string fieldName)
        {
            return RemoveField(GetField(fieldName));
        }

        /// <summary>
        /// Remove field at index.
        /// </summary>
        /// <param name="index">Field index to remove.</param>
        public void RemoveFieldAt(int index)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).RemoveAt(index); });
        }

        /// <summary>
        /// Remove fields range start at specific index.
        /// </summary>
        /// <param name="index">Index from start removing.</param>
        /// <param name="count">Count to remove.</param>
        public void RemoveFieldsRange(int index, int count)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).RemoveRange(index, count); });
        }

        /// <summary>
        /// Remove all fields which satisfy condition.
        /// </summary>
        /// <param name="match">Condition to remove.</param>
        /// <returns>Count of removed fields.</returns>
        public int RemoveAllFields(Predicate<JsonField> match)
        {
            return CastToAndInvoke<JsonObject, int>(() => { return ((JsonObject)_value).RemoveAll(match); });
        }

        /// <summary>
        /// Get field by name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field by name.</returns>
        public JsonField GetField(string fieldName)
        {
            return CastToAndInvoke<JsonObject, JsonField>(() => { return ((JsonObject)_value).GetField(fieldName); });
        }

        /// <summary>
        /// Get field at index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field by index.</returns>
        public JsonField GetFieldAt(int index)
        {
            return CastToAndInvoke<JsonObject, JsonField>(() => { return ((JsonObject)_value).GetFieldAt(index); });
        }

        /// <summary>
        /// Check field existing by name.
        /// </summary>
        /// <param name="fieldName">Field name to check.</param>
        /// <returns>True if exists, otherwise false.</returns>
        public bool HasFieldWithNane(string fieldName)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).HasFieldWithName(fieldName); });
        }

        /// <summary>
        /// Check field existing.
        /// </summary>
        /// <param name="field">Field to check.</param>
        /// <returns>True if exists, otherwise false.</returns>
        public bool ContainsField(JsonField field)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).Contains(field); });
        }

        /// <summary>
        /// Find index of field.
        /// </summary>
        /// <param name="field">Field to find index.</param>
        /// <returns>Index of specific field.</returns>
        public int IndexOfField(JsonField field)
        {
            return CastToAndInvoke<JsonObject, int>(() => { return ((JsonObject)_value).IndexOf(field); });
        }

        /// <summary>
        /// Find field index by field name.
        /// </summary>
        /// <param name="name">Field name to find index.</param>
        /// <returns>Index of finded field</returns>
        public int IndexOfField(string name)
        {
            return CastToAndInvoke<JsonObject, int>(() => { return ((JsonObject)_value).IndexOf(name); });
        }

        /// <summary>
        /// Find first field by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded field.</returns>
        public JsonField FindField(Predicate<JsonField> match)
        {
            return CastToAndInvoke<JsonObject, JsonField>(() => { return ((JsonObject)_value).Find(match); });
        }

        /// <summary>
        /// Find all fields by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded fields.</returns>
        public List<JsonField> FindAllFields(Predicate<JsonField> match)
        {
            return CastToAndInvoke<JsonObject, List<JsonField>>(() => { return ((JsonObject)_value).FindAll(match); });
        }

        /// <summary>
        /// Find index by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded index.</returns>
        public int FindFieldIndex(Predicate<JsonField> match)
        {
            return CastToAndInvoke<JsonObject, int>(() => { return ((JsonObject)_value).FindIndex(match); });
        }

        /// <summary>
        /// Find last field by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded field.</returns>
        public JsonField FindLastField(Predicate<JsonField> match)
        {
            return CastToAndInvoke<JsonObject, JsonField>(() => { return ((JsonObject)_value).FindLast(match); });
        }

        /// <summary>
        /// Find last field index by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded index.</returns>
        public int FindLastFieldIndex(Predicate<JsonField> match)
        {
            return CastToAndInvoke<JsonObject, int>(() => { return ((JsonObject)_value).FindLastIndex(match); });
        }

        /// <summary>
        /// Check if any field satisfy condition.
        /// </summary>
        /// <param name="predicate">Condition to check.</param>
        /// <returns>True if any field satisfy condition.</returns>
        public bool AnyField(Func<JsonField, bool> predicate)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).Any(predicate); });
        }

        /// <summary>
        /// Checl all field to satisfy condition.
        /// </summary>
        /// <param name="predicate">Condition to check.</param>
        /// <returns>True if all field satisfy condition.</returns>
        public bool AllFields(Func<JsonField, bool> predicate)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).All(predicate); });
        }

        /// <summary>
        /// Swap two field by indexes.
        /// </summary>
        /// <param name="first">First field index.</param>
        /// <param name="second">Second field index.</param>
        public void SwapFields(int first, int second)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).SwapFields(first, second); });
        }

        /// <summary>
        /// Swap two fields by fields names.
        /// </summary>
        /// <param name="first">First field name.</param>
        /// <param name="second">Second field name.</param>
        public void SwapFields(string first, string second)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).SwapFields(first, second); });
        }

        /// <summary>
        /// Swap two values by fields indexes.
        /// </summary>
        /// <param name="first">First field index.</param>
        /// <param name="second">Second field index.</param>
        public void SwapFieldsValues(int first, int second)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).SwapValues(first, second); });
        }

        /// <summary>
        /// Swap two values by fields names.
        /// </summary>
        /// <param name="first">First field name.</param>
        /// <param name="second">Second field name.</param>
        public void SwapFieldsValues(string first, string second)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).SwapValues(first, second); });
        }

        /// <summary>
        /// Check field value on equality to JsonNull by index.
        /// </summary>
        /// <param name="index">Index to check.</param>
        /// <returns>True if field value is JsonNull, otherwise false.</returns>
        public bool CheckFieldNull(int index)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).CheckNull(index); });
        }

        /// <summary>
        /// Check field value on equality to JsonNull by field name.
        /// </summary>
        /// <param name="fieldName">Field name to check.</param>
        /// <returns>True if field value is JsonNull, otherwise false.</returns>
        public bool CheckFieldNull(string fieldName)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).CheckNull(fieldName); });
        }

        #region Get values
        /// <summary>
        /// Get value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public JsonValue GetFieldValue(string fieldName)
        {
            return CastToAndInvoke<JsonObject, JsonValue>(() => { return ((JsonObject)_value).GetValue(fieldName); });
        }

        /// <summary>
        /// Get value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public JsonValue GetFieldValue(int index)
        {
            return CastToAndInvoke<JsonObject, JsonValue>(() => { return ((JsonObject)_value).GetValue(index); });
        }

        /// <summary>
        /// Get casted to bool value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public bool GetFieldBool(string fieldName)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).GetBool(fieldName); });
        }

        /// <summary>
        /// Get casted to bool value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public bool GetFieldBool(int index)
        {
            return CastToAndInvoke<JsonObject, bool>(() => { return ((JsonObject)_value).GetBool(index); });
        }

        /// <summary>
        /// Get casted to byte value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public byte GetFieldByte(string fieldName)
        {
            return CastToAndInvoke<JsonObject, byte>(() => { return ((JsonObject)_value).GetByte(fieldName); });
        }

        /// <summary>
        /// Get casted to byte value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public byte GetFieldByte(int index)
        {
            return CastToAndInvoke<JsonByte, byte>(() => { return ((JsonObject)_value).GetByte(index); });
        }

        /// <summary>
        /// Get casted to char value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public char GetFieldChar(string fieldName)
        {
            return CastToAndInvoke<JsonObject, char>(() => { return ((JsonObject)_value).GetChar(fieldName); });
        }

        /// <summary>
        /// Get casted to char value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public char GetFieldChar(int index)
        {
            return CastToAndInvoke<JsonChar, char>(() => { return ((JsonObject)_value).GetChar(index); });
        }

        /// <summary>
        /// Get casted to decimal value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public decimal GetFieldDecimal(string fieldName)
        {
            return CastToAndInvoke<JsonObject, decimal>(() => { return ((JsonObject)_value).GetDecimal(fieldName); });
        }

        /// <summary>
        /// Get casted to decimal value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public decimal GetFieldDecimal(int index)
        {
            return CastToAndInvoke<JsonDecimal, decimal>(() => { return ((JsonObject)_value).GetDecimal(index); });
        }

        /// <summary>
        /// Get casted to double value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public double GetFieldDouble(string fieldName)
        {
            return CastToAndInvoke<JsonObject, double>(() => { return ((JsonObject)_value).GetDouble(fieldName); });
        }

        /// <summary>
        /// Get casted to double value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public double GetFieldDouble(int index)
        {
            return CastToAndInvoke<JsonDouble, double>(() => { return ((JsonObject)_value).GetDouble(index); });
        }

        /// <summary>
        /// Get casted to float value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public float GetFieldFloat(string fieldName)
        {
            return CastToAndInvoke<JsonObject, float>(() => { return ((JsonObject)_value).GetFloat(fieldName); });
        }

        /// <summary>
        /// Get casted to float value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public float GetFieldFloat(int index)
        {
            return CastToAndInvoke<JsonFloat, float>(() => { return ((JsonObject)_value).GetFloat(index); });
        }

        /// <summary>
        /// Get casted to int value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public int GetFieldInt(string fieldName)
        {
            return CastToAndInvoke<JsonObject, int>(() => { return ((JsonObject)_value).GetInt(fieldName); });
        }

        /// <summary>
        /// Get casted to int value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public int GetFieldInt(int index)
        {
            return CastToAndInvoke<JsonInt, int>(() => { return ((JsonObject)_value).GetInt(index); });
        }

        /// <summary>
        /// Get casted to long value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public long GetFieldLong(string fieldName)
        {
            return CastToAndInvoke<JsonObject, long>(() => { return ((JsonObject)_value).GetLong(fieldName); });
        }

        /// <summary>
        /// Get casted to long value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public long GetFieldLong(int index)
        {
            return CastToAndInvoke<JsonLong, long>(() => { return ((JsonObject)_value).GetLong(index); });
        }

        /// <summary>
        /// Get casted to JsonNull value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public JsonNull GetFieldNull(string fieldName)
        {
            return CastToAndInvoke<JsonObject, JsonNull>(() => { return ((JsonObject)_value).GetNull(fieldName); });
        }

        /// <summary>
        /// Get casted to JsonNull value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public JsonNull GetFieldNull(int index)
        {
            return CastToAndInvoke<JsonNull, JsonNull>(() => { return ((JsonObject)_value).GetNull(index); });
        }

        /// <summary>
        /// Get casted to JsonNumber value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public JsonNumber GetFieldNumber(string fieldName)
        {
            return CastToAndInvoke<JsonObject, JsonNumber>(() => { return ((JsonObject)_value).GetNumber(fieldName); });
        }

        /// <summary>
        /// Get casted to JsonNumber value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public JsonNumber GetFieldNumber(int index)
        {
            return CastToAndInvoke<JsonNumber, JsonNumber>(() => { return ((JsonObject)_value).GetNumber(index); });
        }

        /// <summary>
        /// Get casted to sbyte value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public sbyte GetFieldSByte(string fieldName)
        {
            return CastToAndInvoke<JsonObject, sbyte>(() => { return ((JsonObject)_value).GetSByte(fieldName); });
        }

        /// <summary>
        /// Get casted to sbyte value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public sbyte GetFieldSByte(int index)
        {
            return CastToAndInvoke<JsonSByte, sbyte>(() => { return ((JsonObject)_value).GetSByte(index); });
        }

        /// <summary>
        /// Get casted to short value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public short GetFieldShort(string fieldName)
        {
            return CastToAndInvoke<JsonObject, short>(() => { return ((JsonObject)_value).GetShort(fieldName); });
        }

        /// <summary>
        /// Get casted to short value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public short GetFieldShort(int index)
        {
            return CastToAndInvoke<JsonShort, short>(() => { return ((JsonObject)_value).GetShort(index); });
        }

        /// <summary>
        /// Get casted to string value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public string GetFieldString(string fieldName)
        {
            return CastToAndInvoke<JsonObject, string>(() => { return ((JsonObject)_value).GetString(fieldName); });
        }

        /// <summary>
        /// Get casted to string value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public string GetFieldString(int index)
        {
            return CastToAndInvoke<JsonString, string>(() => { return ((JsonObject)_value).GetString(index); });
        }

        /// <summary>
        /// Get casted to uint value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public uint GetFieldUInt(string fieldName)
        {
            return CastToAndInvoke<JsonObject, uint>(() => { return ((JsonObject)_value).GetUInt(fieldName); });
        }

        /// <summary>
        /// Get casted to uint value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public uint GetFieldUInt(int index)
        {
            return CastToAndInvoke<JsonUInt, uint>(() => { return ((JsonObject)_value).GetUInt(index); });
        }

        /// <summary>
        /// Get casted to ulong value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public ulong GetFieldULong(string fieldName)
        {
            return CastToAndInvoke<JsonObject, ulong>(() => { return ((JsonObject)_value).GetULong(fieldName); });
        }

        /// <summary>
        /// Get casted to ulong value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public ulong GetFieldULong(int index)
        {
            return CastToAndInvoke<JsonULong, ulong>(() => { return ((JsonObject)_value).GetULong(index); });
        }

        /// <summary>
        /// Get casted to ushort value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public ushort GetFieldUShort(string fieldName)
        {
            return CastToAndInvoke<JsonObject, ushort>(() => { return ((JsonObject)_value).GetUShort(fieldName); });
        }

        /// <summary>
        /// Get casted to ushort value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public ushort GetFieldUShort(int index)
        {
            return CastToAndInvoke<JsonUShort, ushort>(() => { return ((JsonObject)_value).GetUShort(index); });
        }

        /// <summary>
        /// Get casted to JsonObject value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public JsonObject GetFieldObject(string fieldName)
        {
            return CastToAndInvoke<JsonObject, JsonObject>(() => { return ((JsonObject)_value).GetObject(fieldName); });
        }

        /// <summary>
        /// Get casted to JsonObject value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public JsonObject GetFieldObject(int index)
        {
            return CastToAndInvoke<JsonObject, JsonObject>(() => { return ((JsonObject)_value).GetObject(index); });
        }

        /// <summary>
        /// Get casted to JsonArray value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public JsonArray GetFieldArray(string fieldName)
        {
            return CastToAndInvoke<JsonObject, JsonArray>(() => { return ((JsonObject)_value).GetArray(fieldName); });
        }

        /// <summary>
        /// Get casted to JsonArray value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public JsonArray GetFieldArray(int index)
        {
            return CastToAndInvoke<JsonArray, JsonArray>(() => { return ((JsonObject)_value).GetArray(index); });
        }
        #endregion

        /// <summary>
        /// Replace field by index.
        /// </summary>
        /// <param name="index">Index to replace.</param>
        /// <param name="field">New field.</param>
        public void ReplaceField(int index, JsonField field)
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).Replace(index, field); });
        }

        /// <summary>
        /// Create field and replace them with the old.
        /// </summary>
        /// <param name="index">Index to replace.</param>
        /// <param name="name">Field name.</param>
        /// <param name="value">Field value.</param>
        public void ReplaceField(int index, string name, JsonValue value)
        {
            ReplaceField(index, new JsonField(name, value));
        }

        /// <summary>
        /// Clear all fields.
        /// </summary>
        public void ClearFields()
        {
            CastToAndInvoke<JsonObject>(() => { ((JsonObject)_value).Clear(); });
        }
        #endregion

        #region JsonArray
        /// <summary>
        /// Count of elements in array.
        /// </summary>
        public int ValuesCount
        {
            get
            {
                return CastToAndInvoke<JsonArray, int>(() => ((JsonArray)_value).Count);
            }
        }

        /// <summary>
        /// Add element to end of array.
        /// </summary>
        /// <param name="value">Element to add.</param>
        public void AddValue(JsonValue value)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).Add(value); });
        }

        /// <summary>
        /// Add elements to end of array.
        /// </summary>
        /// <param name="values">Elements to add.</param>
        public void AddValuesRange(IEnumerable<JsonValue> values)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).AddRange(values); });
        }

        /// <summary>
        /// Insert an element in array at a specific index.
        /// </summary>
        /// <param name="index">Index to insert.</param>
        /// <param name="value">Element to insert.</param>
        public void InsertValue(int index, JsonValue value)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).Insert(index, value); });
        }

        /// <summary>
        /// Insert an element in array at a specific index.
        /// </summary>
        /// <param name="index">Index to insert.</param>
        /// <param name="values">Element to insert.</param>
        public void InsertValueRange(int index, IEnumerable<JsonValue> values)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).InsertRange(index, values); });
        }

        /// <summary>
        /// Insert element in array at a specific index or append if index more than elements count.
        /// </summary>
        /// <param name="index">Index to insert.</param>
        /// <param name="value">Element to insert or add.</param>
        public void InsertOrAppendValue(int index, JsonValue value)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).InsertOrAppend(index, value); });
        }

        /// <summary>
        /// Remove element from array.
        /// </summary>
        /// <param name="value">Element to remove.</param>
        /// <returns></returns>
        public bool RemoveValue(JsonValue value)
        {
            return CastToAndInvoke<JsonArray, bool>(() => { return ((JsonArray)_value).Remove(value); });
        }

        /// <summary>
        /// Remove element at a specific position.
        /// </summary>
        /// <param name="index">Element index.</param>
        public void RemoveValueAt(int index)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).RemoveAt(index); });
        }

        /// <summary>
        /// Remove elements range from array start from specific index.
        /// </summary>
        /// <param name="index">Index from which start removing.</param>
        /// <param name="count">Count to remove.</param>
        public void RemoveValuesRange(int index, int count)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).RemoveRange(index, count); });
        }

        /// <summary>
        /// Remove all element which satisfy the condition.
        /// </summary>
        /// <param name="predicate">Condition.</param>
        /// <returns>Removed count.</returns>
        public int RemoveAllValues(Predicate<JsonValue> predicate)
        {
            return CastToAndInvoke<JsonArray, int>(() => { return ((JsonArray)_value).RemoveAll(predicate); });
        }

        /// <summary>
        /// Check if an element exists.
        /// </summary>
        /// <param name="value">Element to check.</param>
        /// <returns>True if contaions.</returns>
        public bool ContainsValue(JsonValue value)
        {
            return CastToAndInvoke<JsonArray, bool>(() => { return ((JsonArray)_value).Contains(value); });
        }

        /// <summary>
        /// Find index of specific element.
        /// </summary>
        /// <param name="value">Element by which need find index.</param>
        /// <returns>Index of element.</returns>
        public int IndexOfValue(JsonValue value)
        {
            return CastToAndInvoke<JsonArray, int>(() => { return ((JsonArray)_value).IndexOf(value); });
        }

        /// <summary>
        /// Find element by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded element.</returns>
        public JsonValue FindValue(Predicate<JsonValue> match)
        {
            return CastToAndInvoke<JsonArray, JsonValue>(() => { return ((JsonArray)_value).Find(match); });
        }

        /// <summary>
        /// Find all elements by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded elements.</returns>
        public List<JsonValue> FindAllValues(Predicate<JsonValue> match)
        {
            return CastToAndInvoke<JsonArray, List<JsonValue>>(() => { return ((JsonArray)_value).FindAll(match); });
        }

        /// <summary>
        /// Find index of element by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Index of matched element.</returns>
        public int FindValueIndex(Predicate<JsonValue> match)
        {
            return CastToAndInvoke<JsonArray, int>(() => { return ((JsonArray)_value).FindIndex(match); });
        }

        /// <summary>
        /// Find last element by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded element.</returns>
        public JsonValue FindLastValue(Predicate<JsonValue> match)
        {
            return CastToAndInvoke<JsonArray, JsonValue>(() => { return ((JsonArray)_value).FindLast(match); });
        }

        /// <summary>
        /// Find index of last finded element.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Index of finded element.</returns>
        public int FindLastValueIndex(Predicate<JsonValue> match)
        {
            return CastToAndInvoke<JsonArray, int>(() => { return ((JsonArray)_value).FindLastIndex(match); });
        }

        /// <summary>
        /// Check if any element satisfy to condition.
        /// </summary>
        /// <param name="predicate">Condition to check.</param>
        /// <returns>True of any element satisfy to condition.</returns>
        public bool AnyValue(Func<JsonValue, bool> predicate)
        {
            return CastToAndInvoke<JsonArray, bool>(() => { return ((JsonArray)_value).Any(predicate); });
        }

        /// <summary>
        /// Check if all elements satisfy to condition.
        /// </summary>
        /// <param name="predicate">Condition to check.</param>
        /// <returns>True if all element satisfy to condition.</returns>
        public bool AllValues(Func<JsonValue, bool> predicate)
        {
            return CastToAndInvoke<JsonArray, bool>(() => { return ((JsonArray)_value).All(predicate); });
        }

        /// <summary>
        /// Swap two values by indexes.
        /// </summary>
        /// <param name="first">First index.</param>
        /// <param name="second">Second index.</param>
        public void SwapValues(int first, int second)
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).SwapValues(first, second); });
        }

        /// <summary>
        /// Check element on equality JsonNull.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public bool CheckValueNull(int index)
        {
            return CastToAndInvoke<JsonArray, bool>(() => { return ((JsonArray)_value).CheckNull(index); });
        }

        #region Get values
        /// <summary>
        /// Get element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public JsonValue GetValue(int index)
        {
            return CastToAndInvoke<JsonArray, JsonValue>(() => { return ((JsonArray)_value)[index]; });
        }

        /// <summary>
        /// Get casted to bool element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public bool GetBool(int index)
        {
            return CastToAndInvoke<JsonArray, bool>(() => { return ((JsonBool)((JsonArray)_value)[index]).Value; });
        }

        /// <summary>
        /// Get casted to byte element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public byte GetByte(int index)
        {
            return CastToAndInvoke<JsonArray, byte>(() => { return ((JsonByte)((JsonArray)_value)[index]).Value; });
        }

        /// <summary>
        /// Get casted to char element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public char GetChar(int index)
        {
            return CastToAndInvoke<JsonArray, char>(() => { return ((JsonChar)((JsonArray)_value)[index]).Value; });
        }

        /// <summary>
        /// Get casted to decimal element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public decimal GetDecimal(int index)
        {
            return CastToAndInvoke<JsonArray, decimal>(() => { return ((JsonDecimal)((JsonArray)_value)[index]).Value; });
        }

        /// <summary>
        /// Get casted to double element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public double GetDouble(int index)
        {
            return CastToAndInvoke<JsonArray, double>(() => { return ((JsonDouble)((JsonArray)_value)[index]).Value; });
        }

        /// <summary>
        /// Get casted to float element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public float GetFloat(int index)
        {
            return CastToObjectOrArrayAndInvoke(() => { return ((JsonObject)_value).GetFloat(index); }, () => { return ((JsonArray)_value).GetFloat(index); });
        }

        /// <summary>
        /// Get casted to int element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public int GetInt(int index)
        {
            return CastToAndInvoke<JsonArray, int>(() => { return ((JsonInt)((JsonArray)_value)[index]).Value; });
        }

        /// <summary>
        /// Get casted to long element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public long GetLong(int index)
        {
            return CastToAndInvoke<JsonArray, long>(() => { return ((JsonLong)((JsonArray)_value)[index]).Value; });
        }

        /// <summary>
        /// Get casted to JsonNull element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public JsonNull GetNull(int index)
        {
            return CastToAndInvoke<JsonArray, JsonNull>(() => { return ((JsonNull)((JsonArray)_value)[index]); });
        }

        /// <summary>
        /// Get casted to JsonNumber element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public JsonNumber GetNumber(int index)
        {
            return CastToAndInvoke<JsonArray, JsonNumber>(() => { return ((JsonNumber)((JsonArray)_value)[index]); });
        }

        /// <summary>
        /// Get casted to sbyte element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public sbyte GetSByte(int index)
        {
            return CastToAndInvoke<JsonArray, sbyte>(() => { return ((JsonSByte)((JsonArray)_value)[index]).Value; });
        }

        /// <summary>
        /// Get casted to short element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public short GetShort(int index)
        {
            return CastToAndInvoke<JsonArray, short>(() => { return ((JsonShort)((JsonArray)_value)[index]).Value; });
        }

        /// <summary>
        /// Get casted to string element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public string GetString(int index)
        {
            return CastToAndInvoke<JsonArray, string>(() => { return ((JsonString)((JsonArray)_value)[index]).Value; });
        }

        /// <summary>
        /// Get casted to uint element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public uint GetUInt(int index)
        {
            return CastToAndInvoke<JsonArray, uint>(() => { return ((JsonUInt)((JsonArray)_value)[index]).Value; });
        }

        /// <summary>
        /// Get casted to ulong element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public ulong GetULong(int index)
        {
            return CastToAndInvoke<JsonArray, ulong>(() => { return ((JsonULong)((JsonArray)_value)[index]).Value; });
        }

        /// <summary>
        /// Get casted to ushort element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public ushort GetUShort(int index)
        {
            return CastToAndInvoke<JsonArray, ushort>(() => { return ((JsonUShort)((JsonArray)_value)[index]).Value; });
        }

        /// <summary>
        /// Get casted to JsonObject element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public JsonObject GetObject(int index)
        {
            return CastToAndInvoke<JsonArray, JsonObject>(() => { return ((JsonObject)((JsonArray)_value)[index]); });
        }

        /// <summary>
        /// Get casted to JsonArray element at index.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <returns></returns>
        public JsonArray GetArray(int index)
        {
            return CastToAndInvoke<JsonArray, JsonArray>(() => { return ((JsonArray)((JsonArray)_value)[index]); });
        }
        #endregion

        /// <summary>
        /// Clear all elements.
        /// </summary>
        public void ClearValues()
        {
            CastToAndInvoke<JsonArray>(() => { ((JsonArray)_value).Clear(); });
        }
        #endregion

        /// <summary>
        /// Convert wrapped value to json string representation.
        /// </summary>
        /// <returns>String representation of this object.</returns>
        public override string ToString()
        {
            return _value.ToString();
        }
        #endregion

        #region Indexers
        /// <summary>
        /// Get or set field value (if wrapped value is JsonObject) or JsonValue (if wrapped value is JsonArray) by index.
        /// </summary>
        /// <param name="index">Index to get or set.</param>
        /// <returns>JsonValue wrapped to JsonWrap.</returns>
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

        /// <summary>
        /// Get or set field value by field name.
        /// </summary>
        /// <param name="index">Index to get or set.</param>
        /// <returns>JsonValue wrapped to JsonWrap.</returns>
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