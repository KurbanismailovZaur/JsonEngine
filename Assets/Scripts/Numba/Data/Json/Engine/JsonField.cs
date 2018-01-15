using Numba.Data.Json.Engine.DataTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    public class JsonField
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
        private string _name;

        private JsonValue _value;
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public JsonValue Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion

        #region Constructors
        public JsonField(string name, JsonValue value)
        {
            _name = name;
            _value = value;
        }

        public JsonField(string name, bool value)
        {
            _name = name;
            _value = new JsonBool(value);
        }

        public JsonField(string name, byte value)
        {
            _name = name;
            _value = new JsonByte(value);
        }

        public JsonField(string name, char value)
        {
            _name = name;
            _value = new JsonChar(value);
        }

        public JsonField(string name, decimal value)
        {
            _name = name;
            _value = new JsonDecimal(value);
        }

        public JsonField(string name, double value)
        {
            _name = name;
            _value = new JsonDouble(value);
        }

        public JsonField(string name, float value)
        {
            _name = name;
            _value = new JsonFloat(value);
        }

        public JsonField(string name, int value)
        {
            _name = name;
            _value = new JsonInt(value);
        }

        public JsonField(string name, long value)
        {
            _name = name;
            _value = new JsonLong(value);
        }

        public JsonField(string name, sbyte value)
        {
            _name = name;
            _value = new JsonSByte(value);
        }

        public JsonField(string name, short value)
        {
            _name = name;
            _value = new JsonShort(value);
        }

        public JsonField(string name, string value)
        {
            _name = name;
            _value = new JsonString(value);
        }

        public JsonField(string name, uint value)
        {
            _name = name;
            _value = new JsonUInt(value);
        }

        public JsonField(string name, ulong value)
        {
            _name = name;
            _value = new JsonULong(value);
        }

        public JsonField(string name, ushort value)
        {
            _name = name;
            _value = new JsonUShort(value);
        }
        #endregion

        #region Methods
        #region Set value
        private void SetJsonValue(JsonValue value)
        {
            _value = value;
        }

        public void SetValue(bool value)
        {
            SetJsonValue(new JsonBool(value));
        }

        public void SetValue(byte value)
        {
            SetJsonValue(new JsonByte(value));
        }

        public void SetValue(char value)
        {
            SetJsonValue(new JsonChar(value));
        }

        public void SetValue(decimal value)
        {
            SetJsonValue(new JsonDecimal(value));
        }

        public void SetValue(double value)
        {
            SetJsonValue(new JsonDouble(value));
        }

        public void SetValue(float value)
        {
            SetJsonValue(new JsonFloat(value));
        }

        public void SetValue(int value)
        {
            SetJsonValue(new JsonInt(value));
        }

        public void SetValue(long value)
        {
            SetJsonValue(new JsonLong(value));
        }

        public void SetValue(sbyte value)
        {
            SetJsonValue(new JsonSByte(value));
        }

        public void SetValue(short value)
        {
            SetJsonValue(new JsonShort(value));
        }

        public void SetValue(string value)
        {
            SetJsonValue(new JsonString(value));
        }

        public void SetValue(uint value)
        {
            SetJsonValue(new JsonUInt(value));
        }

        public void SetValue(ulong value)
        {
            SetJsonValue(new JsonULong(value));
        }

        public void SetValue(ushort value)
        {
            SetJsonValue(new JsonUShort(value));
        }

        public void SetValue(JsonNull value)
        {
            SetJsonValue(value);
        }

        public void SetValue(JsonNumber value)
        {
            SetJsonValue(value);
        }

        public void SetValue(JsonObject value)
        {
            SetJsonValue(value);
        }

        public void SetValue(JsonArray value)
        {
            SetJsonValue(value);
        }
        #endregion

        public override string ToString()
        {
            return string.Format("\"{0}\":{1}", _name ?? "", _value == null ? "null" : _value.ToString());
        }
        #endregion

        #region Events handlers
        #endregion
        #endregion
    }
}