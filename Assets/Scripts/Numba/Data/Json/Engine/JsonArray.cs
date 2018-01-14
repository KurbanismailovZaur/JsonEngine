using Numba.Data.Json.Engine.DataTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    public class JsonArray : IJsonValue, IEnumerable<IJsonValue>
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
        private List<IJsonValue> _values = new List<IJsonValue>();
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        public JsonType Category { get { return JsonType.Array; } }

        public JsonDataType Type { get { return JsonDataType.Array; } }

        public int Count { get { return _values.Count; } }
        #endregion

        #region Methods
        #region Constructors
        public JsonArray() { }

        public JsonArray(IEnumerable<IJsonValue> enumerable)
        {
            _values.AddRange(enumerable);
        }
        #endregion

        #region IEnumerable<JsonValue> interface implementation
        public IEnumerator<IJsonValue> GetEnumerator()
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
        public void Add(IJsonValue value)
        {
            _values.Add(value);
        }

        public void Add(bool value)
        {
            Add(new JsonBool(value));
        }

        public void Add(byte value)
        {
            Add(new JsonByte(value));
        }

        public void Add(char value)
        {
            Add(new JsonChar(value));
        }

        public void Add(decimal value)
        {
            Add(new JsonDecimal(value));
        }

        public void Add(double value)
        {
            Add(new JsonDouble(value));
        }

        public void Add(float value)
        {
            Add(new JsonFloat(value));
        }

        public void Add(int value)
        {
            Add(new JsonInt(value));
        }

        public void Add(long value)
        {
            Add(new JsonLong(value));
        }

        public void Add(sbyte value)
        {
            Add(new JsonSByte(value));
        }

        public void Add(short value)
        {
            Add(new JsonShort(value));
        }

        public void Add(string value)
        {
            Add(new JsonString(value));
        }

        public void Add(uint value)
        {
            Add(new JsonUInt(value));
        }

        public void Add(ulong value)
        {
            Add(new JsonULong(value));
        }

        public void Add(ushort value)
        {
            Add(new JsonUShort(value));
        }
        #endregion

        public void AddRange(IEnumerable<IJsonValue> values)
        {
            foreach (IJsonValue value in values)
            {
                _values.Add(value ?? new JsonNull());
            }
        }

        #region Insert
        public void Insert(int index, IJsonValue value)
        {
            _values.Insert(index, value);

        }
        public void Insert(int index, bool value)
        {
            _values.Insert(index, new JsonBool(value));
        }

        public void Insert(int index, byte value)
        {
            _values.Insert(index, new JsonByte(value));
        }

        public void Insert(int index, char value)
        {
            _values.Insert(index, new JsonChar(value));
        }

        public void Insert(int index, decimal value)
        {
            _values.Insert(index, new JsonDecimal(value));
        }

        public void Insert(int index, double value)
        {
            _values.Insert(index, new JsonDouble(value));
        }

        public void Insert(int index, float value)
        {
            _values.Insert(index, new JsonFloat(value));
        }

        public void Insert(int index, int value)
        {
            _values.Insert(index, new JsonInt(value));
        }

        public void Insert(int index, long value)
        {
            _values.Insert(index, new JsonLong(value));
        }

        public void Insert(int index, sbyte value)
        {
            _values.Insert(index, new JsonSByte(value));
        }

        public void Insert(int index, short value)
        {
            _values.Insert(index, new JsonShort(value));
        }

        public void Insert(int index, string value)
        {
            _values.Insert(index, new JsonString(value));
        }

        public void Insert(int index, uint value)
        {
            _values.Insert(index, new JsonUInt(value));
        }

        public void Insert(int index, ulong value)
        {
            _values.Insert(index, new JsonULong(value));
        }

        public void Insert(int index, ushort value)
        {
            _values.Insert(index, new JsonUShort(value));
        }
        #endregion

        public void InsertRange(int index, IEnumerable<IJsonValue> values)
        {
            foreach (IJsonValue value in values)
            {
                _values.Insert(index++, value ?? new JsonNull());
            }
        }
        #endregion

        #region Remove
        #region Remove
        public void Remove(IJsonValue value)
        {
            _values.Remove(value);
        }

        public void Remove(bool value)
        {
            Remove(new JsonBool(value));
        }

        public void Remove(byte value)
        {
            Remove(new JsonByte(value));
        }

        public void Remove(char value)
        {
            Remove(new JsonChar(value));
        }

        public void Remove(decimal value)
        {
            Remove(new JsonDecimal(value));
        }

        public void Remove(double value)
        {
            Remove(new JsonDouble(value));
        }

        public void Remove(float value)
        {
            Remove(new JsonFloat(value));
        }

        public void Remove(int value)
        {
            Remove(new JsonInt(value));
        }

        public void Remove(long value)
        {
            Remove(new JsonLong(value));
        }

        public void Remove(sbyte value)
        {
            Remove(new JsonSByte(value));
        }

        public void Remove(short value)
        {
            Remove(new JsonShort(value));
        }

        public void Remove(string value)
        {
            Remove(new JsonString(value));
        }

        public void Remove(uint value)
        {
            Remove(new JsonUInt(value));
        }

        public void Remove(ulong value)
        {
            Remove(new JsonULong(value));
        }

        public void Remove(ushort value)
        {
            Remove(new JsonUShort(value));
        }
        #endregion

        public void RemoveAt(int index)
        {
            _values.RemoveAt(index);
        }

        public void RemoveAll(Predicate<IJsonValue> predicate)
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
        public IJsonValue Find(Predicate<IJsonValue> predicate)
        {
            return _values.Find(predicate);
        }

        public List<IJsonValue> FindAll(Predicate<IJsonValue> predicate)
        {
            return _values.FindAll(predicate);
        }

        public int FindIndex(Predicate<IJsonValue> predicate)
        {
            return _values.FindIndex(predicate);
        }

        public IJsonValue FindLast(Predicate<IJsonValue> predicate)
        {
            return _values.FindLast(predicate);
        }

        public int FindLastIndex(Predicate<IJsonValue> predicate)
        {
            return _values.FindLastIndex(predicate);
        }
        #endregion

        public bool Contains(IJsonValue value)
        {
            return _values.Contains(value);
        }

        public IJsonValue this[int index]
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