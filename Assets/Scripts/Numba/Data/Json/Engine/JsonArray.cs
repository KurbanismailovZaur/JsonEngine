using Numba.Data.Json.Engine.DataTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    /// <summary>
    /// Represent dynamically sized array of json type (JsonBool, JsonFloat, JsonObject or other) data.
    /// </summary>
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
        private List<JsonValue> _values;
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        /// <summary>
        /// Returns category for this object.
        /// </summary>
        public override JsonTypeCategory Category { get { return JsonTypeCategory.Array; } }

        /// <summary>
        /// Returns type for this object.
        /// </summary>
        public override JsonDataType Type { get { return JsonDataType.Array; } }

        /// <summary>
        /// Count of elements in array.
        /// </summary>
        public int Count { get { return _values.Count; } }
        #endregion

        #region Methods
        #region Constructors
        /// <summary>
        /// Create empty array.
        /// </summary>
        public JsonArray()
        {
            _values = new List<JsonValue>();
        }

        /// <summary>
        /// Create array with specific capacity.
        /// </summary>
        /// <param name="capacity"></param>
        public JsonArray(int capacity)
        {
            _values = new List<JsonValue>(capacity);
        }

        /// <summary>
        /// Create array and initialize it with enumerable.
        /// </summary>
        /// <param name="enumerable"></param>
        public JsonArray(IEnumerable<JsonValue> enumerable)
        {
            _values = new List<JsonValue>();
            _values.AddRange(enumerable);
        }

        /// <summary>
        /// Parse string data as JsonArray value.
        /// </summary>
        /// <param name="jsonArrayData">String for parsing.</param>
        public JsonArray(string jsonArrayData)
        {
            _values = Json.Parse<JsonArray>(jsonArrayData)._values;
        }
        #endregion

        #region IEnumerable<JsonValue> interface implementation
        /// <summary>
        /// Get enumerator for this array.
        /// </summary>
        /// <returns>JsonValue Enumerator for this array.</returns>
        public IEnumerator<JsonValue> GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        /// <summary>
        /// Get enumerator for this array.
        /// </summary>
        /// <returns>Enumerator for this array.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _values.GetEnumerator();
        }
        #endregion

        /// <summary>
        /// Add element to end of array.
        /// </summary>
        /// <param name="value">Element to add.</param>
        public void Add(JsonValue value)
        {
            _values.Add(value ?? JsonNull.value);
        }

        /// <summary>
        /// Add elements to end of array.
        /// </summary>
        /// <param name="values">Elements to add.</param>
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

        /// <summary>
        /// Insert an element in array at a specific index.
        /// </summary>
        /// <param name="index">Index to insert.</param>
        /// <param name="value">Element to insert.</param>
        public void Insert(int index, JsonValue value)
        {
            _values.Insert(index, value ?? JsonNull.value);
        }

        /// <summary>
        /// Insert an element in array at a specific index.
        /// </summary>
        /// <param name="index">Index to insert.</param>
        /// <param name="values">Element to insert.</param>
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

        /// <summary>
        /// Insert element in array at a specific index.
        /// </summary>
        /// <param name="index">Index to insert.</param>
        /// <param name="value">Element to insert.</param>
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

        /// <summary>
        /// Remove element from array.
        /// </summary>
        /// <param name="value">Element to remove.</param>
        /// <returns></returns>
        public bool Remove(JsonValue value)
        {
            return _values.Remove(value ?? JsonNull.value);
        }

        /// <summary>
        /// Remove element at a specific position.
        /// </summary>
        /// <param name="index">Element index.</param>
        public void RemoveAt(int index)
        {
            _values.RemoveAt(index);
        }

        /// <summary>
        /// Remove elements range from array start from specific index.
        /// </summary>
        /// <param name="index">Index from which start removing.</param>
        /// <param name="count">Count to remove.</param>
        public void RemoveRange(int index, int count)
        {
            _values.RemoveRange(index, count);
        }

        /// <summary>
        /// Remove all element which satisfy the condition.
        /// </summary>
        /// <param name="predicate">Condition.</param>
        /// <returns>Removed count.</returns>
        public int RemoveAll(Predicate<JsonValue> predicate)
        {
            return _values.RemoveAll(predicate);
        }

        /// <summary>
        /// Clear all elements.
        /// </summary>
        public void Clear()
        {
            _values.Clear();
        }

        /// <summary>
        /// Check if an element exists.
        /// </summary>
        /// <param name="value">Element to check.</param>
        /// <returns>True if contaions.</returns>
        public bool Contains(JsonValue value)
        {
            return _values.Contains(value);
        }

        /// <summary>
        /// Find index of specific element.
        /// </summary>
        /// <param name="value">Element by which need find index.</param>
        /// <returns>Index of element.</returns>
        public int IndexOf(JsonValue value)
        {
            return _values.IndexOf(value);
        }

        /// <summary>
        /// Find element by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded element.</returns>
        public JsonValue Find(Predicate<JsonValue> match)
        {
            return _values.Find(match);
        }

        /// <summary>
        /// Find all elements by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded elements.</returns>
        public List<JsonValue> FindAll(Predicate<JsonValue> match)
        {
            return _values.FindAll(match);
        }

        /// <summary>
        /// Find index of element by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Index of matched element.</returns>
        public int FindIndex(Predicate<JsonValue> match)
        {
            return _values.FindIndex(match);
        }

        /// <summary>
        /// Find last element by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded element.</returns>
        public JsonValue FindLast(Predicate<JsonValue> match)
        {
            return _values.FindLast(match);
        }

        /// <summary>
        /// Find index of last finded element.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Index of finded element.</returns>
        public int FindLastIndex(Predicate<JsonValue> match)
        {
            return _values.FindLastIndex(match);
        }

        /// <summary>
        /// Check if any element satisfy to condition.
        /// </summary>
        /// <param name="predicate">Condition to check.</param>
        /// <returns>True of any element satisfy to condition.</returns>
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

        /// <summary>
        /// Check if all elements satisfy to condition.
        /// </summary>
        /// <param name="predicate">Condition to check.</param>
        /// <returns>True if all element satisfy to condition.</returns>
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

        public bool CheckNull(int index)
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