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
        public JsonType Type { get { return JsonType.Array; } }

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
        public void Add<T>(T value) where T : IJsonValue
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
                Add(value ?? new JsonNull());
            }
        }

        #region Insert
        public void Insert<T>(int index, T value) where T : IJsonValue
        {
            _values.Insert(index, value);
        }

        public void Insert(int index, bool value)
        {
            Insert<JsonBool>(index, value);
        }

        public void Insert(int index, byte value)
        {
            Insert<JsonByte>(index, value);
        }

        public void Insert(int index, char value)
        {
            Insert<JsonChar>(index, value);
        }

        public void Insert(int index, decimal value)
        {
            Insert<JsonDecimal>(index, value);
        }

        public void Insert(int index, double value)
        {
            Insert<JsonDouble>(index, value);
        }

        public void Insert(int index, float value)
        {
            Insert<JsonFloat>(index, value);
        }

        public void Insert(int index, int value)
        {
            Insert<JsonInt>(index, value);
        }

        public void Insert(int index, long value)
        {
            Insert<JsonLong>(index, value);
        }

        public void Insert(int index, sbyte value)
        {
            Insert<JsonSByte>(index, value);
        }

        public void Insert(int index, short value)
        {
            Insert<JsonShort>(index, value);
        }

        public void Insert(int index, string value)
        {
            Insert<JsonString>(index, value);
        }

        public void Insert(int index, uint value)
        {
            Insert<JsonUInt>(index, value);
        }

        public void Insert(int index, ulong value)
        {
            Insert<JsonULong>(index, value);
        }

        public void Insert(int index, ushort value)
        {
            Insert<JsonUShort>(index, value);
        }
        #endregion

        public void InsertRange(int index, IEnumerable<IJsonValue> values)
        {
            foreach (IJsonValue value in values)
            {
                Insert(index++, value ?? new JsonNull());
            }
        }
        #endregion

        #region Remove
        #region Remove
        public void Remove<T>(T value) where T : IJsonValue
        {
            _values.Remove(value);
        }

        private void RemovePrimitive<T1>(T1 value) where T1 : IJsonDataType
        {
            IJsonValue primitive = _values.Find((x) => { return x.Equals(value); });

            Remove(primitive);
        }

        public void Remove(bool value)
        {
            RemovePrimitive<JsonBool>(value);
        }

        public void Remove(byte value)
        {
            RemovePrimitive<JsonByte>(value);
        }

        public void Remove(char value)
        {
            RemovePrimitive<JsonChar>(value);
        }

        public void Remove(decimal value)
        {
            RemovePrimitive<JsonDecimal>(value);
        }

        public void Remove(double value)
        {
            RemovePrimitive<JsonDouble>(value);
        }

        public void Remove(float value)
        {
            RemovePrimitive < JsonFloat>(value);
        }

        public void Remove(int value)
        {
            RemovePrimitive<JsonInt>(value);
        }

        public void Remove(long value)
        {
            RemovePrimitive<JsonLong>(value);
        }

        public void Remove(sbyte value)
        {
            RemovePrimitive<JsonSByte>(value);
        }

        public void Remove(short value)
        {
            RemovePrimitive<JsonShort>(value);
        }

        public void Remove(string value)
        {
            RemovePrimitive<JsonString>(value);
        }

        public void Remove(uint value)
        {
            RemovePrimitive<JsonUInt>(value);
        }

        public void Remove(ulong value)
        {
            RemovePrimitive<JsonULong>(value);
        }

        public void Remove(ushort value)
        {
            RemovePrimitive<JsonUShort>(value);
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

        public void Clear()
        {
            _values.Clear();
        }
        #endregion

        #region Get
        public IJsonValue Find(Predicate<IJsonValue> predicate)
        {
            return _values.Find(predicate);
        }

        public List<IJsonValue> FindAll(Predicate<IJsonValue> predicate)
        {
            return _values.FindAll(predicate);
        }

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