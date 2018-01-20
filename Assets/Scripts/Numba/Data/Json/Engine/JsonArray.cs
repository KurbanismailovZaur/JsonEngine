using Numba.Data.Json.Engine.DataTypes;
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

        public void Add(JsonValue value)
        {
            _values.Add(value ?? new JsonNull());
        }

        public void AddRange(IEnumerable<JsonValue> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException("values");
            }

            foreach (JsonValue value in values)
            {
                Add(value);
            }
        }

        public void Insert(int index, JsonValue value)
        {
            _values.Insert(index, value ?? new JsonNull());
        }

        public void InsertRange(int index, IEnumerable<JsonValue> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException("values");
            }

            foreach (JsonValue value in values)
            {
                _values.Insert(index++, value);
            }
        }

        public bool Remove(JsonValue value)
        {
            return _values.Remove(value ?? new JsonNull());
        }

        public void RemoveAt(int index)
        {
            _values.RemoveAt(index);
        }

        public int RemoveAll(Predicate<JsonValue> predicate)
        {
            return _values.RemoveAll(predicate);
        }

        public void RemoveRange(int index, int count)
        {
            _values.RemoveRange(index, count);
        }

        public void Clear()
        {
            _values.Clear();
        }

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

        public bool Contains(JsonValue value)
        {
            return _values.Contains(value);
        }

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

        #region Indexers
        public JsonValue this[int index]
        {
            get { return _values[index]; }
            set { _values[index] = value; }
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}