using Numba.Data.Json.Engine.DataTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    public class JsonObject : JsonValue, IEnumerable<JsonField>
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
        private List<JsonField> _fields = new List<JsonField>();
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        public override JsonTypeCategory Category { get { return JsonTypeCategory.Object; } }

        public override JsonDataType Type { get { return JsonDataType.Object; } }

        public int Count { get { return _fields.Count; } }
        #endregion

        #region Methods
        #region Constructors
        public JsonObject() { }

        public JsonObject(IEnumerable<JsonField> fields)
        {
            AddRange(fields);
        }

        public JsonObject(string jsonObjectData)
        {
            _fields = Json.Parse<JsonObject>(jsonObjectData)._fields;
        }
        #endregion

        #region IEnumerable<IJsonValue> interface implementation
        public IEnumerator<JsonField> GetEnumerator()
        {
            return _fields.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _fields.GetEnumerator();
        }
        #endregion

        public void Add(JsonField field)
        {
            if (field == null)
            {
                throw new ArgumentNullException("field");
            }

            if (HasFieldWithName(field.Name.Value))
            {
                throw new ArgumentException(string.Format("Field with name \"{0}\" already existed", field.Name));
            }

            _fields.Add(field);
        }

        public void Add(string name, JsonValue value)
        {
            Add(new JsonField(name, value));
        }

        public void AddRange(IEnumerable<JsonField> fields)
        {
            if (fields == null)
            {
                throw new ArgumentNullException("fields");
            }

            foreach (JsonField field in fields)
            {
                Add(field);
            }
        }

        public void Insert(int index, JsonField field)
        {
            if (field == null)
            {
                throw new ArgumentNullException("field");
            }

            if (HasFieldWithName(field.Name.Value))
            {
                throw new ArgumentException(string.Format("Field with name \"{0}\" already existed", field.Name));
            }

            _fields.Insert(index, field);
        }

        public void Insert(int index, string name, JsonValue value)
        {
            Insert(index, new JsonField(name, value));
        }

        public void InsertRange(int index, IEnumerable<JsonField> fields)
        {
            if (fields == null)
            {
                throw new ArgumentNullException("field");
            }

            foreach (JsonField field in fields)
            {
                Insert(index++, field);
            }
        }

        public void InsertOrAppend(int index, JsonField field)
        {
            if (index > _fields.Count)
            {
                Add(field);
            }
            else
            {
                Insert(index, field);
            }
        }

        public void InsertOrAppend(int index, string name, JsonValue value)
        {
            InsertOrAppend(index, new JsonField(name, value));
        }

        public bool Remove(JsonField field)
        {
            return _fields.Remove(field);
        }

        public bool Remove(string name)
        {
            return Remove(GetField(name));
        }

        public void RemoveAt(int index)
        {
            _fields.RemoveAt(index);
        }

        public void RemoveRange(int index, int count)
        {
            _fields.RemoveRange(index, count);
        }

        public int RemoveAll(Predicate<JsonField> match)
        {
            return _fields.RemoveAll(match);
        }

        public void Clear()
        {
            _fields.Clear();
        }

        public JsonField GetField(string fieldName)
        {
            JsonField field = Find(x => x.Name == fieldName);

            if (field == null)
            {
                throw new ArgumentException(string.Format("Field with name \"{0}\" not exist", fieldName));
            }

            return field;
        }

        public JsonField GetFieldAt(int index)
        {
            return _fields[index];
        }

        public bool HasFieldWithName(string fieldName)
        {
            return Any(x => x.Name == fieldName);
        }

        public bool Contains(JsonField field)
        {
            return _fields.Contains(field);
        }

        public int IndexOf(JsonField field)
        {
            return _fields.IndexOf(field);
        }

        public int IndexOf(string name)
        {
            return FindIndex(x => x.Name == name);
        }

        public JsonField Find(Predicate<JsonField> match)
        {
            return _fields.Find(match);
        }

        public List<JsonField> FindAll(Predicate<JsonField> match)
        {
            return _fields.FindAll(match);
        }

        public int FindIndex(Predicate<JsonField> match)
        {
            return _fields.FindIndex(match);
        }

        public JsonField FindLast(Predicate<JsonField> match)
        {
            return _fields.FindLast(match);
        }

        public int FindLastIndex(Predicate<JsonField> match)
        {
            return _fields.FindLastIndex(match);
        }

        public bool Any(Func<JsonField, bool> predicate)
        {
            foreach (JsonField field in _fields)
            {
                if (predicate.Invoke(field))
                {
                    return true;
                }
            }

            return false;
        }

        public bool All(Func<JsonField, bool> predicate)
        {
            foreach (JsonField field in _fields)
            {
                if (!predicate.Invoke(field))
                {
                    return false;
                }
            }

            return true;
        }

        #region Get values
        public JsonValue GetValue(int index)
        {
            return GetFieldAt(index).Value;
        }

        public JsonValue GetValue(string fieldName)
        {
            return GetField(fieldName).Value;
        }

        public bool GetBool(int index)
        {
            return ((JsonBool)GetFieldAt(index).Value).Value;
        }

        public bool GetBool(string fieldName)
        {
            return ((JsonBool)GetField(fieldName).Value).Value;
        }

        public byte GetByte(int index)
        {
            return ((JsonByte)GetFieldAt(index).Value).Value;
        }

        public byte GetByte(string fieldName)
        {
            return ((JsonByte)GetField(fieldName).Value).Value;
        }

        public char GetChar(int index)
        {
            return ((JsonChar)GetFieldAt(index).Value).Value;
        }

        public char GetChar(string fieldName)
        {
            return ((JsonChar)GetField(fieldName).Value).Value;
        }

        public decimal GetDecimal(int index)
        {
            return ((JsonDecimal)GetFieldAt(index).Value).Value;
        }

        public decimal GetDecimal(string fieldName)
        {
            return ((JsonDecimal)GetField(fieldName).Value).Value;
        }

        public double GetDouble(int index)
        {
            return ((JsonDouble)GetFieldAt(index).Value).Value;
        }

        public double GetDouble(string fieldName)
        {
            return ((JsonDouble)GetField(fieldName).Value).Value;
        }

        public float GetFloat(int index)
        {
            return ((JsonFloat)GetFieldAt(index).Value).Value;
        }

        public float GetFloat(string fieldName)
        {
            return ((JsonFloat)GetField(fieldName).Value).Value;
        }

        public int GetInt(int index)
        {
            return ((JsonInt)GetFieldAt(index).Value).Value;
        }

        public int GetInt(string fieldName)
        {
            return ((JsonInt)GetField(fieldName).Value).Value;
        }

        public long GetLong(int index)
        {
            return ((JsonLong)GetFieldAt(index).Value).Value;
        }

        public long GetLong(string fieldName)
        {
            return ((JsonLong)GetField(fieldName).Value).Value;
        }

        public JsonNull GetNull(int index)
        {
            return (JsonNull)GetFieldAt(index).Value;
        }

        public JsonNull GetNull(string fieldName)
        {
            return ((JsonNull)GetField(fieldName).Value);
        }

        public JsonNumber GetNumber(int index)
        {
            return (JsonNumber)GetFieldAt(index).Value;
        }

        public JsonNumber GetNumber(string fieldName)
        {
            return ((JsonNumber)GetField(fieldName).Value);
        }

        public sbyte GetSByte(int index)
        {
            return ((JsonSByte)GetFieldAt(index).Value).Value;
        }

        public sbyte GetSByte(string fieldName)
        {
            return ((JsonSByte)GetField(fieldName).Value).Value;
        }

        public short GetShort(int index)
        {
            return ((JsonShort)GetFieldAt(index).Value).Value;
        }

        public short GetShort(string fieldName)
        {
            return ((JsonShort)GetField(fieldName).Value).Value;
        }

        public string GetString(int index)
        {
            return ((JsonString)GetFieldAt(index).Value).Value;
        }

        public string GetString(string fieldName)
        {
            return ((JsonString)GetField(fieldName).Value).Value;
        }

        public uint GetUInt(int index)
        {
            return ((JsonUInt)GetFieldAt(index).Value).Value;
        }

        public uint GetUInt(string fieldName)
        {
            return ((JsonUInt)GetField(fieldName).Value).Value;
        }

        public ulong GetULong(int index)
        {
            return ((JsonULong)GetFieldAt(index).Value).Value;
        }

        public ulong GetULong(string fieldName)
        {
            return ((JsonULong)GetField(fieldName).Value).Value;
        }

        public ushort GetUShort(int index)
        {
            return ((JsonUShort)GetFieldAt(index).Value).Value;
        }

        public ushort GetUShort(string fieldName)
        {
            return ((JsonUShort)GetField(fieldName).Value).Value;
        }

        public JsonObject GetObject(int index)
        {
            return (JsonObject)GetFieldAt(index).Value;
        }

        public JsonObject GetObject(string fieldName)
        {
            return ((JsonObject)GetField(fieldName).Value);
        }

        public JsonArray GetArray(int index)
        {
            return (JsonArray)GetFieldAt(index).Value;
        }

        public JsonArray GetArray(string fieldName)
        {
            return ((JsonArray)GetField(fieldName).Value);
        }
        #endregion

        public void Replace(int index, JsonField field)
        {
            RemoveAt(index);
            Insert(index, field);
        }

        public void Replace(int index, string name, JsonValue value)
        {
            Replace(index, new JsonField(name, value));
        }

        public void SwapFields(int first, int second)
        {
            if (first == second)
            {
                return;
            }

            int left = first < second ? first : second;
            int right = second > first ? second : first;

            JsonField leftField = _fields[left];
            JsonField rightField = _fields[right];

            RemoveAt(right);
            Replace(left, rightField);
            InsertOrAppend(right, leftField);
        }

        public void SwapFields(string first, string second)
        {
            if (first == second)
            {
                return;
            }

            JsonField firstField = GetField(first);
            JsonField secondField = GetField(second);

            JsonValue firstValue = firstField.Value;
            firstField.Value = secondField.Value;

            secondField.Value = firstValue;
        }

        public void SwapValues(int first, int second)
        {
            if (first == second)
            {
                return;
            }
            
            JsonValue firstValue = _fields[first].Value;
            JsonValue secondValue = _fields[second].Value;

            GetFieldAt(first).Value = secondValue;
            GetFieldAt(second).Value = firstValue;
        }

        public void SwapValues(string first, string second)
        {
            if (first == second)
            {
                return;
            }

            JsonField firstField = GetField(first);
            JsonField secondField = GetField(second);

            JsonValue firstValue = firstField.Value;

            firstField.Value = secondField.Value;
            secondField.Value = firstValue;
        }

        public bool CheckNull(int index)
        {
            return GetFieldAt(index).Value is JsonNull;
        }

        public bool CheckNull(string fieldName)
        {
            return GetField(fieldName).Value is JsonNull;
        }

        public override string ToString()
        {
            if (_fields.Count == 0)
            {
                return "{}";
            }

            StringBuilder builder = new StringBuilder("{");

            for (int i = 0; i < _fields.Count - 1; i++)
            {
                builder.AppendFormat("{0}{1}", _fields[i].ToString(), ",");
            }

            builder.AppendFormat("{0}{1}", _fields[_fields.Count - 1].ToString(), "}");

            return builder.ToString();
        }
        #endregion

        #region Indexers
        public JsonValue this[int index]
        {
            get { return GetValue(index); }
            set { GetFieldAt(index).Value = value; }
        }

        public JsonValue this[string fieldName]
        {
            get { return GetValue(fieldName); }
            set
            {
                JsonField field = Find(x => x.Name == fieldName);

                if (field == null)
                {
                    Add(fieldName, value);
                }
                else
                {
                    field.Value = value;
                }
            }
        }
        #endregion
        #endregion

        #region Event Handlers
        #endregion
    }
}