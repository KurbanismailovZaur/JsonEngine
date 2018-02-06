using Numba.Data.Json.Engine.DataTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    /// <summary>
    /// Represent json object type value.
    /// JsonObject consists of a set of JsonField.
    /// </summary>
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
        /// <summary>
        /// Returns category for this object.
        /// </summary>
        public override JsonTypeCategory Category { get { return JsonTypeCategory.Object; } }

        /// <summary>
        /// Returns type for this object.
        /// </summary>
        public override JsonDataType Type { get { return JsonDataType.Object; } }

        /// <summary>
        /// Count of fields.
        /// </summary>
        public int Count { get { return _fields.Count; } }
        #endregion

        #region Methods
        #region Constructors
        /// <summary>
        /// Create empty JsonObject.
        /// </summary>
        public JsonObject() { }

        /// <summary>
        /// Create JsonObject and initialize it with fields.
        /// </summary>
        /// <param name="fields"></param>
        public JsonObject(IEnumerable<JsonField> fields)
        {
            AddRange(fields);
        }

        /// <summary>
        /// Parse string data as JsonObject value.
        /// </summary>
        /// <param name="jsonObjectData">String for parsing.</param>
        public JsonObject(string jsonObjectData)
        {
            _fields = Json.Parse<JsonObject>(jsonObjectData)._fields;
        }
        #endregion

        #region IEnumerable<IJsonValue> interface implementation
        /// <summary>
        /// Get JsonField enumerator for this object.
        /// </summary>
        /// <returns>JsonValue enumerator for this array.</returns>
        public IEnumerator<JsonField> GetEnumerator()
        {
            return _fields.GetEnumerator();
        }

        /// <summary>
        /// Get enumerator for this object.
        /// </summary>
        /// <returns>Enumerator for this array.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _fields.GetEnumerator();
        }
        #endregion

        /// <summary>
        /// Add field to end.
        /// </summary>
        /// <param name="field">Field to add.</param>
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

        /// <summary>
        /// Create and add field with specific name and value.
        /// </summary>
        /// <param name="name">Field name.</param>
        /// <param name="value">Field value.</param>
        public void Add(string name, JsonValue value)
        {
            Add(new JsonField(name, value));
        }

        /// <summary>
        /// Add fields to end.
        /// </summary>
        /// <param name="fields">Fields enumerable</param>
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

        /// <summary>
        /// Insert field at specific position.
        /// </summary>
        /// <param name="index">Index on which insert field.</param>
        /// <param name="field">Field to insert.</param>
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

        /// <summary>
        /// Create and insert field at specific position.
        /// </summary>
        /// <param name="index">Index on which insert field.</param>
        /// <param name="name">Field name.</param>
        /// <param name="value">Field value.</param>
        public void Insert(int index, string name, JsonValue value)
        {
            Insert(index, new JsonField(name, value));
        }

        /// <summary>
        /// Insert fields start at specific position.
        /// </summary>
        /// <param name="index">Index on which insert fields.</param>
        /// <param name="fields">Fields enumerable.</param>
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

        /// <summary>
        /// Insert field at specific position if index less or equal than fields count, otherwise add field to end.
        /// </summary>
        /// <param name="index">Index on which insert field if it less or equal than fields count.</param>
        /// <param name="field">Field to insert or add.</param>
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

        /// <summary>
        /// Create and insert field at specific position if index less or equal than fields count, otherwise add field to end.
        /// </summary>
        /// <param name="index">Index on which insert field if it less or equal than fields count.</param>
        /// <param name="name">Field name.</param>
        /// <param name="value">Field value.</param>
        public void InsertOrAppend(int index, string name, JsonValue value)
        {
            InsertOrAppend(index, new JsonField(name, value));
        }

        /// <summary>
        /// Remove field.
        /// </summary>
        /// <param name="field">Field to remove.</param>
        /// <returns>True if JsonField removed, otherwise false.</returns>
        public bool Remove(JsonField field)
        {
            return _fields.Remove(field);
        }

        /// <summary>
        /// Remove field by name.
        /// </summary>
        /// <param name="name">Field name to remove.</param>
        /// <returns>True if JsonField removed, otherwise false.</returns>
        public bool Remove(string name)
        {
            return Remove(GetField(name));
        }

        /// <summary>
        /// Remove field at index.
        /// </summary>
        /// <param name="index">Field index to remove.</param>
        public void RemoveAt(int index)
        {
            _fields.RemoveAt(index);
        }

        /// <summary>
        /// Remove fields range start at specific index.
        /// </summary>
        /// <param name="index">Index from start removing.</param>
        /// <param name="count">Count to remove.</param>
        public void RemoveRange(int index, int count)
        {
            _fields.RemoveRange(index, count);
        }

        /// <summary>
        /// Remove all fields which satisfy condition.
        /// </summary>
        /// <param name="match">Condition to remove.</param>
        /// <returns>Count of removed fields.</returns>
        public int RemoveAll(Predicate<JsonField> match)
        {
            return _fields.RemoveAll(match);
        }

        /// <summary>
        /// Clear all fields.
        /// </summary>
        public void Clear()
        {
            _fields.Clear();
        }

        /// <summary>
        /// Get field by name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field by name.</returns>
        public JsonField GetField(string fieldName)
        {
            JsonField field = Find(x => x.Name == fieldName);

            if (field == null)
            {
                throw new ArgumentException(string.Format("Field with name \"{0}\" not exist", fieldName));
            }

            return field;
        }

        /// <summary>
        /// Get field at index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field by index.</returns>
        public JsonField GetFieldAt(int index)
        {
            return _fields[index];
        }

        /// <summary>
        /// Check field existing by name.
        /// </summary>
        /// <param name="fieldName">Field name to check.</param>
        /// <returns>True if exists, otherwise false.</returns>
        public bool HasFieldWithName(string fieldName)
        {
            return Any(x => x.Name == fieldName);
        }

        /// <summary>
        /// Check field existing.
        /// </summary>
        /// <param name="field">Field to check.</param>
        /// <returns>True if exists, otherwise false.</returns>
        public bool Contains(JsonField field)
        {
            return _fields.Contains(field);
        }

        /// <summary>
        /// Find index of field.
        /// </summary>
        /// <param name="field">Field to find index.</param>
        /// <returns>Index of specific field.</returns>
        public int IndexOf(JsonField field)
        {
            return _fields.IndexOf(field);
        }

        /// <summary>
        /// Find field index by field name.
        /// </summary>
        /// <param name="name">Field name to find index.</param>
        /// <returns>Index of finded field</returns>
        public int IndexOf(string name)
        {
            return FindIndex(x => x.Name == name);
        }

        /// <summary>
        /// Find first field by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded field.</returns>
        public JsonField Find(Predicate<JsonField> match)
        {
            return _fields.Find(match);
        }

        /// <summary>
        /// Find all fields by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded fields.</returns>
        public List<JsonField> FindAll(Predicate<JsonField> match)
        {
            return _fields.FindAll(match);
        }

        /// <summary>
        /// Find index by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded index.</returns>
        public int FindIndex(Predicate<JsonField> match)
        {
            return _fields.FindIndex(match);
        }

        /// <summary>
        /// Find last field by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded field.</returns>
        public JsonField FindLast(Predicate<JsonField> match)
        {
            return _fields.FindLast(match);
        }

        /// <summary>
        /// Find last field index by condition.
        /// </summary>
        /// <param name="match">Condition to find.</param>
        /// <returns>Finded index.</returns>
        public int FindLastIndex(Predicate<JsonField> match)
        {
            return _fields.FindLastIndex(match);
        }

        /// <summary>
        /// Check if any field satisfy condition.
        /// </summary>
        /// <param name="predicate">Condition to check.</param>
        /// <returns>True if any field satisfy condition.</returns>
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

        /// <summary>
        /// Checl all field to satisfy condition.
        /// </summary>
        /// <param name="predicate">Condition to check.</param>
        /// <returns>True if all field satisfy condition.</returns>
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
        /// <summary>
        /// Get value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public JsonValue GetValue(int index)
        {
            return GetFieldAt(index).Value;
        }

        /// <summary>
        /// Get value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public JsonValue GetValue(string fieldName)
        {
            return GetField(fieldName).Value;
        }

        /// <summary>
        /// Get casted to bool value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public bool GetBool(int index)
        {
            return ((JsonBool)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to bool value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public bool GetBool(string fieldName)
        {
            return ((JsonBool)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to byte value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public byte GetByte(int index)
        {
            return ((JsonByte)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to byte value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public byte GetByte(string fieldName)
        {
            return ((JsonByte)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to char value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public char GetChar(int index)
        {
            return ((JsonChar)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to char value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public char GetChar(string fieldName)
        {
            return ((JsonChar)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to decimal value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public decimal GetDecimal(int index)
        {
            return ((JsonDecimal)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to decimal value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public decimal GetDecimal(string fieldName)
        {
            return ((JsonDecimal)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to double value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public double GetDouble(int index)
        {
            return ((JsonDouble)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to double value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public double GetDouble(string fieldName)
        {
            return ((JsonDouble)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to float value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public float GetFloat(int index)
        {
            return ((JsonFloat)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to float value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public float GetFloat(string fieldName)
        {
            return ((JsonFloat)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to int value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public int GetInt(int index)
        {
            return ((JsonInt)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to int value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public int GetInt(string fieldName)
        {
            return ((JsonInt)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to long value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public long GetLong(int index)
        {
            return ((JsonLong)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to long value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public long GetLong(string fieldName)
        {
            return ((JsonLong)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to JsonNull value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public JsonNull GetNull(int index)
        {
            return (JsonNull)GetFieldAt(index).Value;
        }

        /// <summary>
        /// Get casted to JsonNull value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public JsonNull GetNull(string fieldName)
        {
            return ((JsonNull)GetField(fieldName).Value);
        }

        /// <summary>
        /// Get casted to JsonNumber value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public JsonNumber GetNumber(int index)
        {
            return (JsonNumber)GetFieldAt(index).Value;
        }

        /// <summary>
        /// Get casted to JsonNumber value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public JsonNumber GetNumber(string fieldName)
        {
            return ((JsonNumber)GetField(fieldName).Value);
        }

        /// <summary>
        /// Get casted to sbyte value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public sbyte GetSByte(int index)
        {
            return ((JsonSByte)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to sbyte value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public sbyte GetSByte(string fieldName)
        {
            return ((JsonSByte)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to short value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public short GetShort(int index)
        {
            return ((JsonShort)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to short value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public short GetShort(string fieldName)
        {
            return ((JsonShort)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to string value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public string GetString(int index)
        {
            return ((JsonString)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to string value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public string GetString(string fieldName)
        {
            return ((JsonString)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to uint value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public uint GetUInt(int index)
        {
            return ((JsonUInt)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to uint value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public uint GetUInt(string fieldName)
        {
            return ((JsonUInt)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to ulong value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public ulong GetULong(int index)
        {
            return ((JsonULong)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to ulong value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public ulong GetULong(string fieldName)
        {
            return ((JsonULong)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to ushort value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public ushort GetUShort(int index)
        {
            return ((JsonUShort)GetFieldAt(index).Value).Value;
        }

        /// <summary>
        /// Get casted to ushort value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public ushort GetUShort(string fieldName)
        {
            return ((JsonUShort)GetField(fieldName).Value).Value;
        }

        /// <summary>
        /// Get casted to JsonObject value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public JsonObject GetObject(int index)
        {
            return (JsonObject)GetFieldAt(index).Value;
        }

        /// <summary>
        /// Get casted to JsonObject value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public JsonObject GetObject(string fieldName)
        {
            return ((JsonObject)GetField(fieldName).Value);
        }

        /// <summary>
        /// Get casted to JsonArray value from field by field index.
        /// </summary>
        /// <param name="index">Field index.</param>
        /// <returns>Field value.</returns>
        public JsonArray GetArray(int index)
        {
            return (JsonArray)GetFieldAt(index).Value;
        }

        /// <summary>
        /// Get casted to JsonArray value from field by field name.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>Field value.</returns>
        public JsonArray GetArray(string fieldName)
        {
            return ((JsonArray)GetField(fieldName).Value);
        }
        #endregion

        /// <summary>
        /// Replace field by index.
        /// </summary>
        /// <param name="index">Index to replace.</param>
        /// <param name="field">New field.</param>
        public void Replace(int index, JsonField field)
        {
            RemoveAt(index);
            Insert(index, field);
        }

        /// <summary>
        /// Create field and replace them with the old.
        /// </summary>
        /// <param name="index">Index to replace.</param>
        /// <param name="name">Field name.</param>
        /// <param name="value">Field value.</param>
        public void Replace(int index, string name, JsonValue value)
        {
            Replace(index, new JsonField(name, value));
        }

        /// <summary>
        /// Swap two field by indexes.
        /// </summary>
        /// <param name="first">First field index.</param>
        /// <param name="second">Second field index.</param>
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

        /// <summary>
        /// Swap two fields by fields names.
        /// </summary>
        /// <param name="first">First field name.</param>
        /// <param name="second">Second field name.</param>
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

        /// <summary>
        /// Swap two values by fields indexes.
        /// </summary>
        /// <param name="first">First field index.</param>
        /// <param name="second">Second field index.</param>
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

        /// <summary>
        /// Swap two values by fields names.
        /// </summary>
        /// <param name="first">First field name.</param>
        /// <param name="second">Second field name.</param>
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

        /// <summary>
        /// Check field value on equality to JsonNull by index.
        /// </summary>
        /// <param name="index">Index to check.</param>
        /// <returns>True if field value is JsonNull, otherwise false.</returns>
        public bool CheckNull(int index)
        {
            return GetFieldAt(index).Value is JsonNull;
        }

        /// <summary>
        /// Check field value on equality to JsonNull by field name.
        /// </summary>
        /// <param name="fieldName">Field name to check.</param>
        /// <returns>True if field value is JsonNull, otherwise false.</returns>
        public bool CheckNull(string fieldName)
        {
            return GetField(fieldName).Value is JsonNull;
        }

        /// <summary>
        /// Convert this object to json representation.
        /// </summary>
        /// <returns>Json representation of this object.</returns>
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
        /// <summary>
        /// Get or set value by field index.
        /// </summary>
        /// <param name="index">Field index to get or set.</param>
        /// <returns>Field value.</returns>
        public JsonValue this[int index]
        {
            get { return GetValue(index); }
            set { GetFieldAt(index).Value = value; }
        }

        /// <summary>
        /// Get or set field value by field name.
        /// </summary>
        /// <param name="fieldName">Field name to get or set.</param>
        /// <returns>Field value.</returns>
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