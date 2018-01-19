using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        public override JsonType Category { get { return JsonType.Object; } }

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

            if (_fields.Any((x) => { return x.Name == field.Name; }))
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

            if (_fields.Any((x) => { return x.Name == field.Name; }))
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
            if (index > _fields.Count - 1)
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

        public void RemoveField(JsonField field)
        {
            _fields.Remove(field);
        }

        public bool RemoveField(string name)
        {
            JsonField field = _fields.Find((x) => { return x.Name == name; });

            return _fields.Remove(field);
        }

        public void RemoveFieldAt(int index)
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
            JsonField field = Find((x) => { return x.Name == fieldName; });

            if (field == null)
            {
                throw new ArgumentException(string.Format("Field with name \"{0}\" not exist", fieldName));
            }

            return field;
        }

        public bool HasField(string fieldName)
        {
            return Find((x) => { return x.Name == fieldName; }) == null ? false : true;
        }

        public bool Contains(JsonField field)
        {
            return _fields.Contains(field);
        }

        public bool Contains(string fieldName)
        {
            return Find((x) => { return x.Name == fieldName; }) == null ? false : true;
        }

        public int GetFieldIndex(JsonField field)
        {
            return _fields.IndexOf(field);
        }

        public int GetFieldIndex(string name)
        {
            JsonField field = _fields.Find((x) => { return x.Name == name; });

            return _fields.IndexOf(field);
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

        #region Get values
        public JsonValue GetValue(string fieldName)
        {
            return GetField(fieldName).Value;
        }

        public bool GetBool(string fieldName)
        {
            return GetField(fieldName).Value.AsBool();
        }

        public byte GetByte(string fieldName)
        {
            return GetField(fieldName).Value.AsByte();
        }

        public char GetChar(string fieldName)
        {
            return GetField(fieldName).Value.AsChar();
        }

        public decimal GetDecimal(string fieldName)
        {
            return GetField(fieldName).Value.AsDecimal();
        }

        public double GetDouble(string fieldName)
        {
            return GetField(fieldName).Value.AsDouble();
        }

        public float GetFloat(string fieldName)
        {
            return GetField(fieldName).Value.AsFloat();
        }

        public int GetInt(string fieldName)
        {
            return GetField(fieldName).Value.AsInt();
        }

        public long GetLong(string fieldName)
        {
            return GetField(fieldName).Value.AsLong();
        }

        public JsonNull GetNull(string fieldName)
        {
            return GetField(fieldName).Value.AsNull();
        }

        public JsonNumber GetNumber(string fieldName)
        {
            return GetField(fieldName).Value.AsNumber();
        }

        public sbyte GetSByte(string fieldName)
        {
            return GetField(fieldName).Value.AsSByte();
        }

        public short GetShort(string fieldName)
        {
            return GetField(fieldName).Value.AsShort();
        }

        public string GetString(string fieldName)
        {
            return GetField(fieldName).Value.AsString();
        }

        public uint GetUInt(string fieldName)
        {
            return GetField(fieldName).Value.AsUInt();
        }

        public ulong GetULong(string fieldName)
        {
            return GetField(fieldName).Value.AsULong();
        }

        public ushort GetUShort(string fieldName)
        {
            return GetField(fieldName).Value.AsUShort();
        }

        public JsonObject GetObject(string fieldName)
        {
            return GetField(fieldName).Value.AsObject();
        }

        public JsonArray GetArray(string fieldName)
        {
            return GetField(fieldName).Value.AsArray();
        }
        #endregion

        public void SetValue(string fieldName, JsonValue value)
        {
            GetField(fieldName).Value = value;
        }

        public void Replace(int index, JsonField field)
        {
            if (index > _fields.Count - 1 || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            JsonField matchField = _fields.Find((x) => { return x.Name == field.Name; });
            if (matchField != null && _fields.IndexOf(matchField) != index)
            {
                throw new ArgumentException(string.Format("Field with name \"{0}\" already existed", field.Name));
            }

            RemoveFieldAt(index);
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

            RemoveFieldAt(right);
            Replace(left, rightField);
            InsertOrAppend(right, leftField);
        }

        public bool CheckNullField(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.Value.IsNull();
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
        public JsonField this[int index]
        {
            get { return _fields[index]; }
            set { Replace(index, value); }
        }

        public JsonValue this[string fieldName]
        {
            get
            {
                return GetField(fieldName).Value;
            }
            set
            {
                JsonField field = Find((x) => { return x.Name == fieldName; });

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