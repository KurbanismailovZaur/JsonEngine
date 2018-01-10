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

        public void Add<T>(string name, T value) where T : IJsonValue 
        {
            JsonField<T> field = new JsonField<T>(name, value);

            Add(field);
        }

        public void Add(string name, bool value)
        {
            Add<JsonBool>(name, value);
        }

        public void Add(string name, byte value)
        {
            Add<JsonByte>(name, value);
        }

        public void Add(string name, char value)
        {
            Add<JsonChar>(name, value);
        }

        public void Add(string name, decimal value)
        {
            Add<JsonDecimal>(name, value);
        }

        public void Add(string name, double value)
        {
            Add<JsonDouble>(name, value);
        }

        public void Add(string name, float value)
        {
            Add<JsonFloat>(name, value);
        }

        public void Add(string name, int value)
        {
            Add<JsonInt>(name, value);
        }

        public void Add(string name, long value)
        {
            Add<JsonLong>(name, value);
        }

        public void Add(string name, sbyte value)
        {
            Add<JsonSByte>(name, value);
        }

        public void Add(string name, short value)
        {
            Add<JsonShort>(name, value);
        }

        public void Add(string name, string value)
        {
            Add<JsonString>(name, value);
        }

        public void Add(string name, uint value)
        {
            Add<JsonUInt>(name, value);
        }

        public void Add(string name, ulong value)
        {
            Add<JsonULong>(name, value);
        }

        public void Add(string name, ushort value)
        {
            Add<JsonUShort>(name, value);
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

        public void Insert<T>(int index, string name, T value) where T: IJsonValue
        {
            JsonField<T> field = new JsonField<T>(name, value);

            Insert(index, field);
        }

        public void Insert(int index, string name, bool value)
        {
            Insert<JsonBool>(index, name, value);
        }

        public void Insert(int index, string name, byte value)
        {
            Insert<JsonByte>(index, name, value);
        }

        public void Insert(int index, string name, char value)
        {
            Insert<JsonChar>(index, name, value);
        }

        public void Insert(int index, string name, decimal value)
        {
            Insert<JsonDecimal>(index, name, value);
        }

        public void Insert(int index, string name, double value)
        {
            Insert<JsonDouble>(index, name, value);
        }

        public void Insert(int index, string name, float value)
        {
            Insert<JsonFloat>(index, name, value);
        }

        public void Insert(int index, string name, int value)
        {
            Insert<JsonInt>(index, name, value);
        }

        public void Insert(int index, string name, long value)
        {
            Insert<JsonLong>(index, name, value);
        }

        public void Insert(int index, string name, sbyte value)
        {
            Insert<JsonSByte>(index, name, value);
        }

        public void Insert(int index, string name, short value)
        {
            Insert<JsonShort>(index, name, value);
        }

        public void Insert(int index, string name, string value)
        {
            Insert<JsonString>(index, name, value);
        }

        public void Insert(int index, string name, uint value)
        {
            Insert<JsonUInt>(index, name, value);
        }

        public void Insert(int index, string name, ulong value)
        {
            Insert<JsonULong>(index, name, value);
        }

        public void Insert(int index, string name, ushort value)
        {
            Insert<JsonUShort>(index, name, value);
        }
        #endregion

        public void InsertRange(int index, IEnumerable<JsonField> fields)
        {
            _fields.InsertRange(index, fields);
        }
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

        public void RemoveAllFields(Predicate<JsonField> predicate)
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
            return Find((x)=> { return x.Name == fieldName; }) == null ? false : true;
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

        #region Get values
        public bool? GetBool(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsBool().Value.Value;
        }

        public byte? GetByte(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsByte().Value.Value;
        }

        public char? GetChar(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsChar().Value.Value;
        }

        public decimal? GetDecimal(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsDecimal().Value.Value;
        }

        public double? GetDouble(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsDouble().Value.Value;
        }

        public float? GetFloat(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsFloat().Value.Value;
        }

        public int? GetInt(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsInt().Value.Value;
        }

        public long? GetLong(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsLong().Value.Value;
        }

        public JsonNumber GetNumber(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsNumber().Value;
        }

        public sbyte? GetSByte(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsSByte().Value.Value;
        }

        public short? GetShort(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsShort().Value.Value;
        }

        public string GetString(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsString().Value.Value;
        }

        public uint? GetUInt(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsUInt().Value.Value;
        }

        public ulong? GetULong(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsULong().Value.Value;
        }

        public ushort? GetUShort(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsUShort().Value.Value;
        }

        public JsonObject GetObject(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsObject().Value;
        }

        public JsonArray GetArray(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsArray().Value;
        }
        #endregion
        #endregion

        #region Set
        public void SetBool(string fieldName, bool? value)
        {
            JsonField field = GetField(fieldName);

            field.AsBool().Value = value;
        }

        public void SetByte(string fieldName, byte? value)
        {
            JsonField field = GetField(fieldName);

            field.AsByte().Value = value;
        }

        public void SetChar(string fieldName, char? value)
        {
            JsonField field = GetField(fieldName);

            field.AsChar().Value = value;
        }

        public void SetDecimal(string fieldName, decimal? value)
        {
            JsonField field = GetField(fieldName);

            field.AsDecimal().Value = value;
        }

        public void SetDouble(string fieldName, double? value)
        {
            JsonField field = GetField(fieldName);

            field.AsDouble().Value = value;
        }

        public void SetFloat(string fieldName, float? value)
        {
            JsonField field = GetField(fieldName);

            field.AsFloat().Value = value;
        }

        public void SetInt(string fieldName, int? value)
        {
            JsonField field = GetField(fieldName);

            field.AsInt().Value = value;
        }

        public void SetLong(string fieldName, long? value)
        {
            JsonField field = GetField(fieldName);

            field.AsLong().Value = value;
        }

        #region Number
        public void SetNumber(string fieldName, byte value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumber().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, decimal value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumber().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, double value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumber().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, float value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumber().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, int value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumber().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, long value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumber().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, sbyte value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumber().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, short value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumber().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, uint value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumber().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, ulong value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumber().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, ushort value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumber().Value.SetNumber(value);
        }
        #endregion

        public void SetSByte(string fieldName, sbyte? value)
        {
            JsonField field = GetField(fieldName);

            field.AsSByte().Value = value;
        }

        public void SetShort(string fieldName, short? value)
        {
            JsonField field = GetField(fieldName);

            field.AsShort().Value = value;
        }

        public void SetString(string fieldName, string value)
        {
            JsonField field = GetField(fieldName);

            field.AsString().Value = value;
        }

        public void SetUInt(string fieldName, uint? value)
        {
            JsonField field = GetField(fieldName);

            field.AsUInt().Value = value;
        }

        public void SetULong(string fieldName, ulong? value)
        {
            JsonField field = GetField(fieldName);

            field.AsULong().Value = value;
        }

        public void SetUShort(string fieldName, ushort? value)
        {
            JsonField field = GetField(fieldName);

            field.AsUShort().Value = value;
        }

        public void SetObject(string fieldName, JsonObject value)
        {
            JsonField field = GetField(fieldName);

            field.AsObject().Value = value;
        }

        public void SetArray(string fieldName, JsonArray value)
        {
            JsonField field = GetField(fieldName);

            field.AsArray().Value = value;
        }
        #endregion

        #region Indexers
        public JsonField this[int index]
        {
            get { return _fields[index]; }
            set
            {
                RemoveFieldAt(index);

                Insert(index, value);
            }
        }

        public IJsonValue this[string fieldName]
        {
            get { return GetField(fieldName).BaseValue; }
        }
        #endregion

        public bool IsNullField(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field is JsonField<JsonNull>;
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