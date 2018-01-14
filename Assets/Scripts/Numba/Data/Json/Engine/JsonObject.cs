using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Exceptions;
using Numba.Data.Json.Engine.Extentions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    public class JsonObject : IJsonValue, IEnumerable<JsonField>
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
        public JsonType Type { get { return JsonType.Object; } }

        public int Count { get { return _fields.Count; } }
        #endregion

        #region Methods
        public JsonObject() { }

        public JsonObject(IEnumerable<JsonField> fields)
        {
            AddRange(fields);
        }

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

        #region Add
        #region Add
        public void Add(JsonField field)
        {
            if (_fields.Any((x) => { return x.Name == field.Name; }))
            {
                throw new ArgumentException(string.Format("Field with name \"{0}\" already existed", field.Name));
            }

            _fields.Add(field);
        }

        public void Add(string name, IJsonValue value)
        {
            Add(new JsonField(name, value));
        }

        public void Add(string name, bool value)
        {
            Add(new JsonField(name, new JsonBool(value)));
        }

        public void Add(string name, byte value)
        {
            Add(new JsonField(name, new JsonByte(value)));
        }

        public void Add(string name, char value)
        {
            Add(new JsonField(name, new JsonChar(value)));
        }

        public void Add(string name, decimal value)
        {
            Add(new JsonField(name, new JsonDecimal(value)));
        }

        public void Add(string name, double value)
        {
            Add(new JsonField(name, new JsonDouble(value)));
        }

        public void Add(string name, float value)
        {
            Add(new JsonField(name, new JsonFloat(value)));
        }

        public void Add(string name, int value)
        {
            Add(new JsonField(name, new JsonInt(value)));
        }

        public void Add(string name, long value)
        {
            Add(new JsonField(name, new JsonLong(value)));
        }

        public void Add(string name, JsonNull value)
        {
            Add(new JsonField(name, value));
        }

        public void Add(string name, JsonNumber value)
        {
            Add(new JsonField(name, value));
        }

        public void Add(string name, sbyte value)
        {
            Add(new JsonField(name, new JsonSByte(value)));
        }

        public void Add(string name, short value)
        {
            Add(new JsonField(name, new JsonShort(value)));
        }

        public void Add(string name, string value)
        {
            Add(new JsonField(name, new JsonString(value)));
        }

        public void Add(string name, uint value)
        {
            Add(new JsonField(name, new JsonUInt(value)));
        }

        public void Add(string name, ulong value)
        {
            Add(new JsonField(name, new JsonULong(value)));
        }

        public void Add(string name, ushort value)
        {
            Add(new JsonField(name, new JsonUShort(value)));
        }

        public void Add(string name, JsonObject value)
        {
            Add(new JsonField(name, value));
        }

        public void Add(string name, JsonArray value)
        {
            Add(new JsonField(name, value));
        }
        #endregion

        public void AddRange(IEnumerable<JsonField> fields)
        {
            foreach (JsonField field in fields)
            {
                Add(field);
            }
        }

        #region Insert
        public void Insert(int index, JsonField field)
        {
            if (_fields.Any((x) => { return x.Name == field.Name; }))
            {
                throw new ArgumentException(string.Format("Field with name \"{0}\" already existed", field.Name));
            }

            _fields.Insert(index, field);
        }

        public void Insert(int index, string name, IJsonValue value)
        {
            Insert(index, new JsonField(name, value));
        }

        public void Insert(int index, string name, bool value)
        {
            Insert(index, new JsonField(name, new JsonBool(value)));
        }

        public void Insert(int index, string name, byte value)
        {
            Insert(index, new JsonField(name, new JsonByte(value)));
        }

        public void Insert(int index, string name, char value)
        {
            Insert(index, new JsonField(name, new JsonChar(value)));
        }

        public void Insert(int index, string name, decimal value)
        {
            Insert(index, new JsonField(name, new JsonDecimal(value)));
        }

        public void Insert(int index, string name, double value)
        {
            Insert(index, new JsonField(name, new JsonDouble(value)));
        }

        public void Insert(int index, string name, float value)
        {
            Insert(index, new JsonField(name, new JsonFloat(value)));
        }

        public void Insert(int index, string name, int value)
        {
            Insert(index, new JsonField(name, new JsonInt(value)));
        }

        public void Insert(int index, string name, long value)
        {
            Insert(index, new JsonField(name, new JsonLong(value)));
        }

        public void Insert(int index, string name, sbyte value)
        {
            Insert(index, new JsonField(name, new JsonSByte(value)));
        }

        public void Insert(int index, string name, short value)
        {
            Insert(index, new JsonField(name, new JsonShort(value)));
        }

        public void Insert(int index, string name, string value)
        {
            Insert(index, new JsonField(name, new JsonString(value)));
        }

        public void Insert(int index, string name, uint value)
        {
            Insert(index, new JsonField(name, new JsonUInt(value)));
        }

        public void Insert(int index, string name, ulong value)
        {
            Insert(index, new JsonField(name, new JsonULong(value)));
        }

        public void Insert(int index, string name, ushort value)
        {
            Insert(index, new JsonField(name, new JsonUShort(value)));
        }

        public void Insert(int index, string name, JsonNull value)
        {
            Insert(index, new JsonField(name, value));
        }

        public void Insert(int index, string name, JsonNumber value)
        {
            Insert(index, new JsonField(name, value));
        }

        public void Insert(int index, string name, JsonObject value)
        {
            Insert(index, new JsonField(name, value));
        }

        public void Insert(int index, string name, JsonArray value)
        {
            Insert(index, new JsonField(name, value));
        }
        #endregion

        public void InsertRange(int index, IEnumerable<JsonField> fields)
        {
            _fields.InsertRange(index, fields);
        }

        #region Insert or append
        public void InsertOrAppend(int index, JsonField field)
        {
            if (index > _fields.Count - 1)
            {
                _fields.Add(field);
            }
            else
            {
                _fields.Insert(index, field);
            }
        }

        public void InsertOrAppend(int index, string name, IJsonValue value)
        {
            InsertOrAppend(index, new JsonField(name, value));
        }

        public void InsertOrAppend(int index, string name, bool value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonBool(value)));
        }

        public void InsertOrAppend(int index, string name, byte value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonByte(value)));
        }

        public void InsertOrAppend(int index, string name, char value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonChar(value)));
        }

        public void InsertOrAppend(int index, string name, decimal value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonDecimal(value)));
        }

        public void InsertOrAppend(int index, string name, double value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonDouble(value)));
        }

        public void InsertOrAppend(int index, string name, float value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonFloat(value)));
        }

        public void InsertOrAppend(int index, string name, int value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonInt(value)));
        }

        public void InsertOrAppend(int index, string name, long value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonLong(value)));
        }

        public void InsertOrAppend(int index, string name, sbyte value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonSByte(value)));
        }

        public void InsertOrAppend(int index, string name, short value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonShort(value)));
        }

        public void InsertOrAppend(int index, string name, string value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonString(value)));
        }

        public void InsertOrAppend(int index, string name, uint value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonUInt(value)));
        }

        public void InsertOrAppend(int index, string name, ulong value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonULong(value)));
        }

        public void InsertOrAppend(int index, string name, ushort value)
        {
            InsertOrAppend(index, new JsonField(name, new JsonUShort(value)));
        }

        public void InsertOrAppend(int index, string name, JsonNull value)
        {
            InsertOrAppend(index, new JsonField(name, value));
        }

        public void InsertOrAppend(int index, string name, JsonNumber value)
        {
            InsertOrAppend(index, new JsonField(name, value));
        }

        public void InsertOrAppend(int index, string name, JsonObject value)
        {
            InsertOrAppend(index, new JsonField(name, value));
        }

        public void InsertOrAppend(int index, string name, JsonArray value)
        {
            InsertOrAppend(index, new JsonField(name, value));
        }
        #endregion
        #endregion

        #region Remove
        public void RemoveField(JsonField field)
        {
            _fields.Remove(field);
        }

        public void RemoveField(string name)
        {
            JsonField field = _fields.Find((x) => { return x.Name == name; });

            _fields.Remove(field);
        }

        public void RemoveFieldAt(int index)
        {
            _fields.RemoveAt(index);
        }

        public void RemoveRange(int index, int count)
        {
            _fields.RemoveRange(index, count);
        }

        public void RemoveFields(Predicate<JsonField> predicate)
        {
            _fields.RemoveAll(predicate);
        }

        public void Clear()
        {
            _fields.Clear();
        }
        #endregion

        #region Get
        public JsonField GetField(string fieldName)
        {
            JsonField field = Find((x) => { return x.Name == fieldName; });

            if (field == null)
            {
                throw new ArgumentException(string.Format("Field with name \"{0}\" not exist", fieldName));
            }

            return field;
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

        public JsonField Find(Predicate<JsonField> predicate)
        {
            return _fields.Find(predicate);
        }

        public List<JsonField> FindAll(Predicate<JsonField> predicate)
        {
            return _fields.FindAll(predicate);
        }

        public int FindIndex(Predicate<JsonField> predicate)
        {
            return _fields.FindIndex(predicate);
        }

        public JsonField FindLast(Predicate<JsonField> predicate)
        {
            return _fields.FindLast(predicate);
        }

        public int FindLastIndex(Predicate<JsonField> predicate)
        {
            return _fields.FindLastIndex(predicate);
        }

        #region Get values
        public IJsonValue GetValue(string fieldName)
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
        #endregion

        #region Set
        public void SetValue(string fieldName, IJsonValue value)
        {
            GetField(fieldName).Value = value;
        }

        public void SetBool(string fieldName, bool value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetByte(string fieldName, byte value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetChar(string fieldName, char value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetDecimal(string fieldName, decimal value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetDouble(string fieldName, double value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetFloat(string fieldName, float value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetInt(string fieldName, int value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetLong(string fieldName, long value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetNull(string fieldName)
        {
            GetField(fieldName).SetValue(new JsonNull());
        }

        #region Number
        public void SetNumber(string fieldName, byte value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetNumber(string fieldName, decimal value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetNumber(string fieldName, double value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetNumber(string fieldName, float value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetNumber(string fieldName, int value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetNumber(string fieldName, long value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetNumber(string fieldName, sbyte value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetNumber(string fieldName, short value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetNumber(string fieldName, uint value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetNumber(string fieldName, ulong value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetNumber(string fieldName, ushort value)
        {
            GetField(fieldName).SetValue(value);
        }
        #endregion

        public void SetSByte(string fieldName, sbyte value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetShort(string fieldName, short value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetString(string fieldName, string value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetUInt(string fieldName, uint value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetULong(string fieldName, ulong value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetUShort(string fieldName, ushort value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetObject(string fieldName, JsonObject value)
        {
            GetField(fieldName).SetValue(value);
        }

        public void SetArray(string fieldName, JsonArray value)
        {
            GetField(fieldName).SetValue(value);
        }
        #endregion

        #region Replace
        public void Replace(int index, JsonField field)
        {
            if (index > _fields.Count - 1)
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

        public void Replace(int index, string name, bool value)
        {
            Replace(index, new JsonField(name, new JsonBool(value)));
        }

        public void Replace(int index, string name, byte value)
        {
            Replace(index, new JsonField(name, new JsonByte(value)));
        }

        public void Replace(int index, string name, char value)
        {
            Replace(index, new JsonField(name, new JsonChar(value)));
        }

        public void Replace(int index, string name, decimal value)
        {
            Replace(index, new JsonField(name, new JsonDecimal(value)));
        }

        public void Replace(int index, string name, double value)
        {
            Replace(index, new JsonField(name, new JsonDouble(value)));
        }

        public void Replace(int index, string name, float value)
        {
            Replace(index, new JsonField(name, new JsonFloat(value)));
        }

        public void Replace(int index, string name, int value)
        {
            Replace(index, new JsonField(name, new JsonInt(value)));
        }

        public void Replace(int index, string name, long value)
        {
            Replace(index, new JsonField(name, new JsonLong(value)));
        }

        public void Replace(int index, string name, JsonNull value)
        {
            Replace(index, new JsonField(name, value));
        }

        public void Replace(int index, string name, JsonNumber value)
        {
            Replace(index, new JsonField(name, value));
        }

        public void Replace(int index, string name, sbyte value)
        {
            Replace(index, new JsonField(name, new JsonSByte(value)));
        }

        public void Replace(int index, string name, short value)
        {
            Replace(index, new JsonField(name, new JsonShort(value)));
        }

        public void Replace(int index, string name, string value)
        {
            Replace(index, new JsonField(name, new JsonString(value)));
        }

        public void Replace(int index, string name, uint value)
        {
            Replace(index, new JsonField(name, new JsonUInt(value)));
        }

        public void Replace(int index, string name, ulong value)
        {
            Replace(index, new JsonField(name, new JsonULong(value)));
        }

        public void Replace(int index, string name, ushort value)
        {
            Replace(index, new JsonField(name, new JsonUShort(value)));
        }

        public void Replace(int index, string name, JsonObject value)
        {
            Replace(index, new JsonField(name, value));
        }

        public void Replace(int index, string name, JsonArray value)
        {
            Replace(index, new JsonField(name, value));
        }
        #endregion

        public void SwapFields(int first, int second)
        {
            if (first == second)
            {
                return;
            }

            int left = first < second ? first : second;
            int right = second > first ? second : first;

            if (left > _fields.Count - 1 || right > _fields.Count - 1)
            {
                throw new IndexOutOfRangeException();
            }

            JsonField leftField = _fields[left];
            JsonField rightField = _fields[right];

            RemoveFieldAt(right);
            Replace(left, rightField);
            InsertOrAppend(right, leftField);
        }

        #region Indexers
        public JsonField this[int index]
        {
            get { return _fields[index]; }
            set { Replace(index, value); }
        }

        public ImplicitCastWrapper this[string fieldName]
        {
            get
            {
                JsonField field = GetField(fieldName);
                return new ImplicitCastWrapper(field.Value);
            }
            set
            {
                JsonField field = Find((x) => { return x.Name == fieldName; });

                if (field == null)
                {
                    Add(fieldName, value.Value);
                }
                else
                {
                    field.Value = value.Value;
                }
            }
        }
        #endregion

        public bool IsNullField(string fieldName)
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

        #region Event Handlers
        #endregion
        #endregion
    }
}