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

        public void Insert<T>(int index, string name, T value) where T : IJsonValue
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

        public void InsertOrAppend<T>(int index, string name, T value) where T : IJsonValue
        {
            InsertOrAppend(index, new JsonField<T>(name, value));
        }

        public void InsertOrAppend(int index, string name, bool value)
        {
            InsertOrAppend(index, new JsonField<JsonBool>(name, value));
        }

        public void InsertOrAppend(int index, string name, byte value)
        {
            InsertOrAppend(index, new JsonField<JsonByte>(name, value));
        }

        public void InsertOrAppend(int index, string name, char value)
        {
            InsertOrAppend(index, new JsonField<JsonChar>(name, value));
        }

        public void InsertOrAppend(int index, string name, decimal value)
        {
            InsertOrAppend(index, new JsonField<JsonDecimal>(name, value));
        }

        public void InsertOrAppend(int index, string name, double value)
        {
            InsertOrAppend(index, new JsonField<JsonDouble>(name, value));
        }

        public void InsertOrAppend(int index, string name, float value)
        {
            InsertOrAppend(index, new JsonField<JsonFloat>(name, value));
        }

        public void InsertOrAppend(int index, string name, int value)
        {
            InsertOrAppend(index, new JsonField<JsonInt>(name, value));
        }

        public void InsertOrAppend(int index, string name, long value)
        {
            InsertOrAppend(index, new JsonField<JsonLong>(name, value));
        }

        public void InsertOrAppend(int index, string name, sbyte value)
        {
            InsertOrAppend(index, new JsonField<JsonSByte>(name, value));
        }

        public void InsertOrAppend(int index, string name, short value)
        {
            InsertOrAppend(index, new JsonField<JsonShort>(name, value));
        }

        public void InsertOrAppend(int index, string name, string value)
        {
            InsertOrAppend(index, new JsonField<JsonString>(name, value));
        }

        public void InsertOrAppend(int index, string name, uint value)
        {
            InsertOrAppend(index, new JsonField<JsonUInt>(name, value));
        }

        public void InsertOrAppend(int index, string name, ulong value)
        {
            InsertOrAppend(index, new JsonField<JsonULong>(name, value));
        }

        public void InsertOrAppend(int index, string name, ushort value)
        {
            InsertOrAppend(index, new JsonField<JsonUShort>(name, value));
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

        #region Get values
        public bool? GetBool(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsBoolField().Value.Value;
        }

        public byte? GetByte(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsByteField().Value.Value;
        }

        public char? GetChar(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsCharField().Value.Value;
        }

        public decimal? GetDecimal(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsDecimalField().Value.Value;
        }

        public double? GetDouble(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsDoubleField().Value.Value;
        }

        public float? GetFloat(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsFloatField().Value.Value;
        }

        public int? GetInt(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsIntField().Value.Value;
        }

        public long? GetLong(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsLongField().Value.Value;
        }

        public JsonNumber GetNumber(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsNumberField().Value;
        }

        public sbyte? GetSByte(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsSByteField().Value.Value;
        }

        public short? GetShort(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsShortField().Value.Value;
        }

        public string GetString(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsStringField().Value.Value;
        }

        public uint? GetUInt(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsUIntField().Value.Value;
        }

        public ulong? GetULong(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsULongField().Value.Value;
        }

        public ushort? GetUShort(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsUShortField().Value.Value;
        }

        public JsonObject GetObject(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsObjectField().Value;
        }

        public JsonArray GetArray(string fieldName)
        {
            JsonField field = GetField(fieldName);

            return field.AsArrayField().Value;
        }
        #endregion
        #endregion

        #region Set
        public void SetBool(string fieldName, bool? value)
        {
            JsonField field = GetField(fieldName);

            field.AsBoolField().Value = value;
        }

        public void SetByte(string fieldName, byte? value)
        {
            JsonField field = GetField(fieldName);

            field.AsByteField().Value = value;
        }

        public void SetChar(string fieldName, char? value)
        {
            JsonField field = GetField(fieldName);

            field.AsCharField().Value = value;
        }

        public void SetDecimal(string fieldName, decimal? value)
        {
            JsonField field = GetField(fieldName);

            field.AsDecimalField().Value = value;
        }

        public void SetDouble(string fieldName, double? value)
        {
            JsonField field = GetField(fieldName);

            field.AsDoubleField().Value = value;
        }

        public void SetFloat(string fieldName, float? value)
        {
            JsonField field = GetField(fieldName);

            field.AsFloatField().Value = value;
        }

        public void SetInt(string fieldName, int? value)
        {
            JsonField field = GetField(fieldName);

            field.AsIntField().Value = value;
        }

        public void SetLong(string fieldName, long? value)
        {
            JsonField field = GetField(fieldName);

            field.AsLongField().Value = value;
        }

        #region Number
        public void SetNumber(string fieldName, byte value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumberField().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, decimal value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumberField().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, double value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumberField().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, float value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumberField().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, int value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumberField().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, long value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumberField().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, sbyte value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumberField().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, short value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumberField().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, uint value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumberField().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, ulong value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumberField().Value.SetNumber(value);
        }

        public void SetNumber(string fieldName, ushort value)
        {
            JsonField field = GetField(fieldName);

            field.AsNumberField().Value.SetNumber(value);
        }
        #endregion

        public void SetSByte(string fieldName, sbyte? value)
        {
            JsonField field = GetField(fieldName);

            field.AsSByteField().Value = value;
        }

        public void SetShort(string fieldName, short? value)
        {
            JsonField field = GetField(fieldName);

            field.AsShortField().Value = value;
        }

        public void SetString(string fieldName, string value)
        {
            JsonField field = GetField(fieldName);

            field.AsStringField().Value = value;
        }

        public void SetUInt(string fieldName, uint? value)
        {
            JsonField field = GetField(fieldName);

            field.AsUIntField().Value = value;
        }

        public void SetULong(string fieldName, ulong? value)
        {
            JsonField field = GetField(fieldName);

            field.AsULongField().Value = value;
        }

        public void SetUShort(string fieldName, ushort? value)
        {
            JsonField field = GetField(fieldName);

            field.AsUShortField().Value = value;
        }

        public void SetObject(string fieldName, JsonObject value)
        {
            JsonField field = GetField(fieldName);

            field.AsObjectField().Value = value;
        }

        public void SetArray(string fieldName, JsonArray value)
        {
            JsonField field = GetField(fieldName);

            field.AsArrayField().Value = value;
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

        public void Replace<T>(int index, string name, T value) where T : IJsonValue
        {
            Replace(index, new JsonField<T>(name, value));
        }

        public void Replace(int index, string name, bool value)
        {
            Replace(index, new JsonField<JsonBool>(name, value));
        }

        public void Replace(int index, string name, byte value)
        {
            Replace(index, new JsonField<JsonByte>(name, value));
        }

        public void Replace(int index, string name, char value)
        {
            Replace(index, new JsonField<JsonChar>(name, value));
        }

        public void Replace(int index, string name, decimal value)
        {
            Replace(index, new JsonField<JsonDecimal>(name, value));
        }

        public void Replace(int index, string name, double value)
        {
            Replace(index, new JsonField<JsonDouble>(name, value));
        }

        public void Replace(int index, string name, float value)
        {
            Replace(index, new JsonField<JsonFloat>(name, value));
        }

        public void Replace(int index, string name, int value)
        {
            Replace(index, new JsonField<JsonInt>(name, value));
        }

        public void Replace(int index, string name, long value)
        {
            Replace(index, new JsonField<JsonLong>(name, value));
        }

        public void Replace(int index, string name, sbyte value)
        {
            Replace(index, new JsonField<JsonSByte>(name, value));
        }

        public void Replace(int index, string name, short value)
        {
            Replace(index, new JsonField<JsonShort>(name, value));
        }

        public void Replace(int index, string name, string value)
        {
            Replace(index, new JsonField<JsonString>(name, value));
        }

        public void Replace(int index, string name, uint value)
        {
            Replace(index, new JsonField<JsonUInt>(name, value));
        }

        public void Replace(int index, string name, ulong value)
        {
            Replace(index, new JsonField<JsonULong>(name, value));
        }

        public void Replace(int index, string name, ushort value)
        {
            Replace(index, new JsonField<JsonUShort>(name, value));
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

        private object GetFieldValueAsObject(JsonField field)
        {
            if (field is JsonField<JsonBool>)
            {
                return ((JsonField<JsonBool>)field).Value.Value;
            }

            if (field is JsonField<JsonByte>)
            {
                return ((JsonField<JsonByte>)field).Value.Value;
            }

            if (field is JsonField<JsonChar>)
            {
                return ((JsonField<JsonChar>)field).Value.Value;
            }

            if (field is JsonField<JsonDecimal>)
            {
                return ((JsonField<JsonDecimal>)field).Value.Value;
            }

            if (field is JsonField<JsonDouble>)
            {
                return ((JsonField<JsonDouble>)field).Value.Value;
            }

            if (field is JsonField<JsonFloat>)
            {
                return ((JsonField<JsonFloat>)field).Value.Value;
            }

            if (field is JsonField<JsonInt>)
            {
                return ((JsonField<JsonInt>)field).Value.Value;
            }

            if (field is JsonField<JsonLong>)
            {
                return ((JsonField<JsonLong>)field).Value.Value;
            }

            if (field is JsonField<JsonNull>)
            {
                return ((JsonField<JsonNull>)field).Value;
            }

            if (field is JsonField<JsonNumber>)
            {
                return ((JsonField<JsonNumber>)field).Value;
            }

            if (field is JsonField<JsonSByte>)
            {
                return ((JsonField<JsonSByte>)field).Value.Value;
            }

            if (field is JsonField<JsonShort>)
            {
                return ((JsonField<JsonShort>)field).Value.Value;
            }

            if (field is JsonField<JsonString>)
            {
                return ((JsonField<JsonString>)field).Value.Value;
            }

            if (field is JsonField<JsonUInt>)
            {
                return ((JsonField<JsonUInt>)field).Value.Value;
            }

            if (field is JsonField<JsonULong>)
            {
                return ((JsonField<JsonULong>)field).Value.Value;
            }

            if (field is JsonField<JsonUShort>)
            {
                return ((JsonField<JsonUShort>)field).Value.Value;
            }

            if (field is JsonField<JsonObject>)
            {
                return ((JsonField<JsonObject>)field).Value;
            }

            if (field is JsonField<JsonArray>)
            {
                return ((JsonField<JsonArray>)field).Value;
            }

            return null;
        }
        #region Indexers
        public JsonField this[int index]
        {
            get { return _fields[index]; }
            set { Replace(index, value); }
        }

        public object this[string fieldName]
        {
            get
            {
                return GetFieldValueAsObject(GetField(fieldName));
            }
            set
            {
                IJsonValue valueWrapper;
                JsonDataType valueDataType = Json.GetDataType(value, out valueWrapper);

                if (valueDataType == JsonDataType.Unknown)
                {
                    throw new ArgumentException("Value is not supported by JSON format");
                }

                JsonField field = Find((x) => { return x.Name == fieldName; });

                if (field == null)
                {
                    switch (valueDataType)
                    {
                        case JsonDataType.Bool:
                            Add(fieldName, valueWrapper);
                            break;
                        case JsonDataType.Byte:
                            break;
                        case JsonDataType.Char:
                            break;
                        case JsonDataType.Decimal:
                            break;
                        case JsonDataType.Double:
                            break;
                        case JsonDataType.Float:
                            break;
                        case JsonDataType.Int:
                            break;
                        case JsonDataType.Long:
                            break;
                        case JsonDataType.Null:
                            break;
                        case JsonDataType.Number:
                            break;
                        case JsonDataType.SByte:
                            break;
                        case JsonDataType.Short:
                            break;
                        case JsonDataType.String:
                            break;
                        case JsonDataType.UInt:
                            break;
                        case JsonDataType.ULong:
                            break;
                        case JsonDataType.UShort:
                            break;
                        case JsonDataType.Object:
                            break;
                        case JsonDataType.Array:
                            break;
                        case JsonDataType.Unknown:
                            break;
                    }
                }
                else
                {

                }
            }
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