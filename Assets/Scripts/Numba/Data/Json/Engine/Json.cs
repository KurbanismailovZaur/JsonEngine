using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    public static class Json
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
        #endregion

        #region Events
        #endregion

        #region Behaviour
        #region Properties
        #endregion

        #region Methods
        #region Parse
        public static JsonValue Parse(string data)
        {
            int currentIndex = -1;
            JsonValue value = ParseValue(data, ref currentIndex);

            if (CheckNextSymbolExisting(data, currentIndex))
            {
                throw new JsonParseException("Incorrect json data");
            }

            return value;
        }

        public static T Parse<T>(string data) where T : JsonValue
        {
            return (T)Parse(data);
        }

        private static JsonValue ParseValue(string data, ref int currentIndex)
        {
            char nextSymbol = GetNextSymbol(data, ref currentIndex);

            if (nextSymbol == '"')
            {
                return ParseString(data, ref currentIndex);
            }

            if (nextSymbol == '-' || char.IsDigit(nextSymbol))
            {
                return ParseNumber(data, ref currentIndex);
            }

            if (nextSymbol == 'n')
            {
                return ParseNull(data, ref currentIndex);
            }

            if (nextSymbol == 't')
            {
                return ParseTrue(data, ref currentIndex);
            }

            if (nextSymbol == 'f')
            {
                return ParseFalse(data, ref currentIndex);
            }

            if (nextSymbol == '{')
            {
                return ParseObject(data, ref currentIndex);
            }

            if (nextSymbol == '[')
            {
                return ParseArray(data, ref currentIndex);
            }

            throw new JsonParseException("Incorrect json data. Unknown type");
        }

        private static char GetNextSymbol(string data, ref int currentIndex)
        {
            if (currentIndex < data.Length - 1)
            {
                currentIndex += 1;

                for (; currentIndex < data.Length; currentIndex++)
                {
                    if (char.IsWhiteSpace(data[currentIndex]))
                    {
                        continue;
                    }

                    return data[currentIndex];
                }
            }

            throw new JsonParseException("Incorrect json data. Can't find next symbol");
        }

        private static void MoveToNextSymbol(string data, ref int currentIndex)
        {
            currentIndex += 1;

            for (; currentIndex < data.Length; currentIndex++)
            {
                if (char.IsWhiteSpace(data[currentIndex]))
                {
                    continue;
                }

                return;
            }

            throw new JsonParseException("Incorrect json data. Can't find next symbol");
        }

        private static bool CheckNextSymbolExisting(string data, int currentIndex)
        {
            if (currentIndex < data.Length - 1)
            {
                currentIndex += 1;

                for (; currentIndex < data.Length; currentIndex++)
                {
                    if (char.IsWhiteSpace(data[currentIndex]))
                    {
                        continue;
                    }

                    return true;
                }
            }

            return false;
        }

        private static JsonString ParseString(string data, ref int currentIndex)
        {
            int startIndex = currentIndex++;

            for (; currentIndex < data.Length; currentIndex++)
            {
                if (data[currentIndex] == '\\')
                {
                    CheckControlSequence(data, ref currentIndex);

                    continue;
                }

                if (data[currentIndex] == '"')
                {
                    return data.Substring(startIndex + 1, currentIndex - startIndex - 1);
                }
            }

            throw new JsonParseException("Incorrect json data. Can't parse string");
        }

        private static void CheckControlSequence(string data, ref int currentIndex)
        {
            switch (data[currentIndex + 1])
            {
                case '"':
                case '\\':
                case '/':
                case 'b':
                case 'f':
                case 'n':
                case 'r':
                case 't':
                    currentIndex += 1;
                    break;
                case 'u':
                    if (currentIndex + 5 > data.Length)
                    {
                        throw new JsonParseException("Incorrect json data. Wrong control sequence");
                    }

                    currentIndex += 1;

                    for (; currentIndex < currentIndex + 3; currentIndex++)
                    {
                        if (!IsHexodecimalSymbol(data[currentIndex + 1]))
                        {
                            throw new JsonParseException("Incorrect json data. Wrong control sequence");
                        }
                    }
                    break;
                default:
                    throw new JsonParseException("Incorrect json data. Wrong control sequence");
            }
        }

        private static bool IsHexodecimalSymbol(char symbol)
        {
            return symbol >= '0' && symbol < '9' || symbol >= 'a' && symbol < 'f' || symbol > 'A' && symbol < 'F';
        }

        private static JsonNumber ParseNumber(string data, ref int currentIndex)
        {
            List<char> endSymbols = new List<char> { ',', '}', ']' };

            int endIndex = currentIndex;
            bool onLastPosition = true;

            for (; endIndex < data.Length; endIndex++)
            {
                if (endSymbols.Contains(data[endIndex]))
                {
                    onLastPosition = false;
                    endIndex -= 1;
                    break;
                }
            }

            string number = string.Empty;

            if (onLastPosition)
            {
                number = data.Substring(currentIndex);
                currentIndex = data.Length - 1;
            }
            else
            {
                number = data.Substring(currentIndex, endIndex - currentIndex + 1);
                currentIndex = endIndex;
            }

            if (number.StartsWith("-0") && number.Length > 2 && char.IsDigit(number[2]) || number[0] == '0' && number.Length > 1 && char.IsDigit(number[1]))
            {
                throw new JsonParseException("Incorrect json data. Can't parse number");
            }

            decimal value = 0;
            try
            {
                value = decimal.Parse(number, NumberStyles.Float, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                throw new JsonParseException("Incorrect json data. Can't parse number");
            }

            return new JsonNumber(value);
        }

        private static JsonNull ParseNull(string data, ref int currentIndex)
        {
            if (data.Substring(currentIndex, 4) == "null")
            {
                currentIndex += 3;

                return JsonNull.value;
            }

            throw new JsonParseException("Incorrect json data. Can't parse null");
        }

        private static JsonBool ParseTrue(string data, ref int currentIndex)
        {
            if (data.Substring(currentIndex, 4) == "true")
            {
                currentIndex += 3;

                return new JsonBool(true);
            }

            throw new JsonParseException("Incorrect json data. Can't parse true");
        }

        private static JsonBool ParseFalse(string data, ref int currentIndex)
        {
            if (data.Substring(currentIndex, 5) == "false")
            {
                currentIndex += 4;

                return new JsonBool(false);
            }

            throw new JsonParseException("Incorrect json data. Can't parse false");
        }

        private static JsonObject ParseObject(string data, ref int currentIndex)
        {
            List<JsonField> fields = new List<JsonField>();

            JsonString fieldName;
            bool isFirstPass = true;

            while (GetNextSymbol(data, ref currentIndex) != '}')
            {
                if (!isFirstPass)
                {
                    if (data[currentIndex] != ',')
                    {
                        throw new JsonParseException("Incorrect json data. Can't parse field in object");
                    }

                    MoveToNextSymbol(data, ref currentIndex);
                }

                isFirstPass = false;

                if (data[currentIndex] != '"')
                {
                    throw new JsonParseException("Incorrect json data. Can't parse field in object");
                }

                fieldName = ParseString(data, ref currentIndex);

                if (GetNextSymbol(data, ref currentIndex) != ':')
                {
                    throw new JsonParseException("Incorrect json data. Can't parse field in object");
                }

                JsonValue value = ParseValue(data, ref currentIndex);

                fields.Add(new JsonField(fieldName.Value, value));
            }

            return new JsonObject(fields);
        }

        private static JsonArray ParseArray(string data, ref int currentIndex)
        {
            JsonArray jsonArray = new JsonArray();

            bool isFirstPass = true;

            while (GetNextSymbol(data, ref currentIndex) != ']')
            {
                if (!isFirstPass)
                {
                    if (data[currentIndex] != ',')
                    {
                        throw new JsonParseException("Incorrect json data. Can't parse json array");
                    }
                }
                else
                {
                    currentIndex -= 1;
                }

                isFirstPass = false;

                jsonArray.Add(ParseValue(data, ref currentIndex));
            }

            return jsonArray;
        }
        #endregion

        public static JsonType GetSupposedType(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return JsonType.Unknown;
            }

            int currentIndex = -1;
            char nextSymbol = GetNextSymbol(data, ref currentIndex);

            if (nextSymbol == '"')
            {
                return JsonType.String;
            }
            else if (nextSymbol == '-' || char.IsDigit(nextSymbol))
            {
                return JsonType.Number;
            }
            else if (nextSymbol == 'n')
            {
                return JsonType.Null;
            }
            else if (nextSymbol == 't' || nextSymbol == 'f')
            {
                return JsonType.Bool;
            }
            else if (nextSymbol == '{')
            {
                return JsonType.Object;
            }
            else if (nextSymbol == '[')
            {
                return JsonType.Array;
            }

            return JsonType.Unknown;
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}