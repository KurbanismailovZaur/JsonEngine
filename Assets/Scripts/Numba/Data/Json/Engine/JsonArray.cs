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

        public void InsertOrAppend(int index, JsonValue value)
        {
            if (index > _values.Count)
            {
                Add(value);
            }
            else
            {
                Insert(index, value);
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

        public void RemoveRange(int index, int count)
        {
            _values.RemoveRange(index, count);
        }

        public int RemoveAll(Predicate<JsonValue> predicate)
        {
            return _values.RemoveAll(predicate);
        }

        public void Clear()
        {
            _values.Clear();
        }

        public bool Contains(JsonValue value)
        {
            return _values.Contains(value);
        }

        public int IndexOf(JsonValue value)
        {
            return _values.IndexOf(value);
        }

        public JsonValue Find(Predicate<JsonValue> match)
        {
            return _values.Find(match);
        }

        public List<JsonValue> FindAll(Predicate<JsonValue> match)
        {
            return _values.FindAll(match);
        }

        public int FindIndex(Predicate<JsonValue> match)
        {
            return _values.FindIndex(match);
        }

        public JsonValue FindLast(Predicate<JsonValue> match)
        {
            return _values.FindLast(match);
        }

        public int FindLastIndex(Predicate<JsonValue> match)
        {
            return _values.FindLastIndex(match);
        }

        public bool Any(Func<JsonValue, bool> predicate)
        {
            foreach (JsonValue value in _values)
            {
                if (predicate.Invoke(value))
                {
                    return true;
                }
            }

            return false;
        }

        public bool All(Func<JsonValue, bool> predicate)
        {
            foreach (JsonValue value in _values)
            {
                if (!predicate.Invoke(value))
                {
                    return false;
                }
            }

            return true;
        }

        #region Get values
        public bool GetBool(int index)
        {
            return ((JsonBool)_values[index]).Value;
        }

        public byte GetByte(int index)
        {
            return ((JsonByte)_values[index]).Value;
        }

        public char GetChar(int index)
        {
            return ((JsonChar)_values[index]).Value;
        }

        public decimal GetDecimal(int index)
        {
            return ((JsonDecimal)_values[index]).Value;
        }

        public double GetDouble(int index)
        {
            return ((JsonDouble)_values[index]).Value;
        }

        public float GetFloat(int index)
        {
            return ((JsonFloat)_values[index]).Value;
        }

        public int GetInt(int index)
        {
            return ((JsonInt)_values[index]).Value;
        }

        public long GetLong(int index)
        {
            return ((JsonLong)_values[index]).Value;
        }

        public JsonNull GetNull(int index)
        {
            return ((JsonNull)_values[index]);
        }

        public JsonNumber GetNumber(int index)
        {
            return ((JsonNumber)_values[index]);
        }

        public sbyte GetSByte(int index)
        {
            return ((JsonSByte)_values[index]).Value;
        }

        public short GetShort(int index)
        {
            return ((JsonShort)_values[index]).Value;
        }

        public string GetString(int index)
        {
            return ((JsonString)_values[index]).Value;
        }

        public uint GetUInt(int index)
        {
            return ((JsonUInt)_values[index]).Value;
        }

        public ulong GetULong(int index)
        {
            return ((JsonULong)_values[index]).Value;
        }

        public ushort GetUShort(int index)
        {
            return ((JsonUShort)_values[index]).Value;
        }

        public JsonObject GetObject(int index)
        {
            return ((JsonObject)_values[index]);
        }

        public JsonArray GetArray(int index)
        {
            return ((JsonArray)_values[index]);
        }
        #endregion

        public void SwapValues(int first, int second)
        {
            if (first == second)
            {
                return;
            }

            JsonValue firstValue = _values[first];
            _values[first] = _values[second];
            _values[second] = firstValue;
        }

        public bool CheckOnNull(int index)
        {
            return _values[index] is JsonNull;
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