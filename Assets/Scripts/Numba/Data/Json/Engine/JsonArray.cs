using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Extentions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    public class JsonArray : JsonValue, IEnumerable<JsonValue>
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
        private List<JsonValue> _values = new List<JsonValue>();
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        public override JsonType Category { get { return JsonType.Array; } }

        public override JsonDataType Type { get { return JsonDataType.Array; } }

        public int Count { get { return _values.Count; } }
        #endregion

        #region Methods
        #region Constructors
        public JsonArray() { }

        public JsonArray(IEnumerable<JsonValue> enumerable)
        {
            _values.AddRange(enumerable);
        }
        #endregion

        #region IEnumerable<JsonValue> interface implementation
        public IEnumerator<JsonValue> GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _values.GetEnumerator();
        }
        #endregion

        #region Add
        #region Add
        public void Add(JsonValue value)
        {
            _values.Add(value);
        }

        public void Add(bool value)
        {
            Add((JsonValue)new JsonBool(value));
        }

        public void Add(byte value)
        {
            Add((JsonValue)new JsonByte(value));
        }

        public void Add(char value)
        {
            Add((JsonValue)new JsonChar(value));
        }

        public void Add(decimal value)
        {
            Add((JsonValue)new JsonDecimal(value));
        }

        public void Add(double value)
        {
            Add((JsonValue)new JsonDouble(value));
        }

        public void Add(float value)
        {
            Add((JsonValue)new JsonFloat(value));
        }

        public void Add(int value)
        {
            Add((JsonValue)new JsonInt(value));
        }

        public void Add(long value)
        {
            Add((JsonValue)new JsonLong(value));
        }

        public void Add(sbyte value)
        {
            Add((JsonValue)new JsonSByte(value));
        }

        public void Add(short value)
        {
            Add((JsonValue)new JsonShort(value));
        }

        public void Add(string value)
        {
            Add((JsonValue)new JsonString(value));
        }

        public void Add(uint value)
        {
            Add((JsonValue)new JsonUInt(value));
        }

        public void Add(ulong value)
        {
            Add((JsonValue)new JsonULong(value));
        }

        public void Add(ushort value)
        {
            Add((JsonValue)new JsonUShort(value));
        }
        #endregion

        public void AddRange(IEnumerable<JsonValue> values)
        {
            foreach (JsonValue value in values)
            {
                _values.Add(value ?? new JsonNull());
            }
        }

        #region Insert
        public void Insert(int index, JsonValue value)
        {
            _values.Insert(index, value);
        }

        public void Insert(int index, bool value)
        {
            Insert(index, (JsonValue)new JsonBool(value));
        }

        public void Insert(int index, byte value)
        {
            Insert(index, (JsonValue)new JsonByte(value));
        }

        public void Insert(int index, char value)
        {
            Insert(index, (JsonValue)new JsonChar(value));
        }

        public void Insert(int index, decimal value)
        {
            Insert(index, (JsonValue)new JsonDecimal(value));
        }

        public void Insert(int index, double value)
        {
            Insert(index, (JsonValue)new JsonDouble(value));
        }

        public void Insert(int index, float value)
        {
            Insert(index, (JsonValue)new JsonFloat(value));
        }

        public void Insert(int index, int value)
        {
            Insert(index, (JsonValue)new JsonInt(value));
        }

        public void Insert(int index, long value)
        {
            Insert(index, (JsonValue)new JsonLong(value));
        }

        public void Insert(int index, sbyte value)
        {
            Insert(index, (JsonValue)new JsonSByte(value));
        }

        public void Insert(int index, short value)
        {
            Insert(index, (JsonValue)new JsonShort(value));
        }

        public void Insert(int index, string value)
        {
            Insert(index, (JsonValue)new JsonString(value));
        }

        public void Insert(int index, uint value)
        {
            Insert(index, (JsonValue)new JsonUInt(value));
        }

        public void Insert(int index, ulong value)
        {
            Insert(index, (JsonValue)new JsonULong(value));
        }

        public void Insert(int index, ushort value)
        {
            Insert(index, (JsonValue)new JsonUShort(value));
        }
        #endregion

        public void InsertRange(int index, IEnumerable<JsonValue> values)
        {
            foreach (JsonValue value in values)
            {
                _values.Insert(index++, value ?? new JsonNull());
            }
        }
        #endregion

        #region Remove
        #region Remove
        public void Remove(JsonValue value)
        {
            _values.Remove(value);
        }

        public void Remove(bool value)
        {
            Remove((JsonValue)new JsonBool(value));
        }

        public void Remove(byte value)
        {
            Remove((JsonValue)new JsonByte(value));
        }

        public void Remove(char value)
        {
            Remove((JsonValue)new JsonChar(value));
        }

        public void Remove(decimal value)
        {
            Remove((JsonValue)new JsonDecimal(value));
        }

        public void Remove(double value)
        {
            Remove((JsonValue)new JsonDouble(value));
        }

        public void Remove(float value)
        {
            Remove((JsonValue)new JsonFloat(value));
        }

        public void Remove(int value)
        {
            Remove((JsonValue)new JsonInt(value));
        }

        public void Remove(long value)
        {
            Remove((JsonValue)new JsonLong(value));
        }

        public void Remove(sbyte value)
        {
            Remove((JsonValue)new JsonSByte(value));
        }

        public void Remove(short value)
        {
            Remove((JsonValue)new JsonShort(value));
        }

        public void Remove(string value)
        {
            Remove((JsonValue)new JsonString(value));
        }

        public void Remove(uint value)
        {
            Remove((JsonValue)new JsonUInt(value));
        }

        public void Remove(ulong value)
        {
            Remove((JsonValue)new JsonULong(value));
        }

        public void Remove(ushort value)
        {
            Remove((JsonValue)new JsonUShort(value));
        }
        #endregion

        public void RemoveAt(int index)
        {
            _values.RemoveAt(index);
        }

        public void RemoveAll(Predicate<JsonValue> predicate)
        {
            _values.RemoveAll(predicate);
        }

        public void RemoveRange(int index, int count)
        {
            _values.RemoveRange(index, count);
        }

        public void Clear()
        {
            _values.Clear();
        }
        #endregion

        #region Get
        #region Find
        public JsonValue Find(Predicate<JsonValue> predicate)
        {
            return _values.Find(predicate);
        }

        public List<JsonValue> FindAll(Predicate<JsonValue> predicate)
        {
            return _values.FindAll(predicate);
        }

        public int FindIndex(Predicate<JsonValue> predicate)
        {
            return _values.FindIndex(predicate);
        }

        public JsonValue FindLast(Predicate<JsonValue> predicate)
        {
            return _values.FindLast(predicate);
        }

        public int FindLastIndex(Predicate<JsonValue> predicate)
        {
            return _values.FindLastIndex(predicate);
        }
        #endregion

        public bool Contains(JsonValue value)
        {
            return _values.Contains(value);
        }

        public JsonValue this[int index]
        {
            get { return _values[index]; }
            set { _values[index] = value; }
        }
        #endregion

        public override string ToString()
        {
            if (_values.Count == 0)
            {
                return "[]";
            }

            StringBuilder builder = new StringBuilder("[");

            for (int i = 0; i < _values.Count - 1; i++)
            {
                builder.AppendFormat("{0}{1}", _values[i].ToString(), ",");
            }

            builder.AppendFormat("{0}{1}", _values[_values.Count - 1].ToString(), "]");

            return builder.ToString();
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}