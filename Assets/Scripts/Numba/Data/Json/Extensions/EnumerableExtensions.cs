using Numba.Data.Json.Engine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Extentsions
{
    public static class EnumerableExtensions
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
        public static JsonArray ToJsonArray(this IEnumerable<JsonValue> enumerable)
        {
            return new JsonArray(enumerable);
        }

        public static JsonArray ToJsonArray(this IEnumerable<bool> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (bool item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }

        public static JsonArray ToJsonArray(this IEnumerable<byte> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (byte item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }

        public static JsonArray ToJsonArray(this IEnumerable<char> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (char item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }

        public static JsonArray ToJsonArray(this IEnumerable<decimal> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (decimal item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }

        public static JsonArray ToJsonArray(this IEnumerable<double> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (double item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }

        public static JsonArray ToJsonArray(this IEnumerable<float> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (float item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }

        public static JsonArray ToJsonArray(this IEnumerable<int> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (int item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }

        public static JsonArray ToJsonArray(this IEnumerable<long> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (long item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }

        public static JsonArray ToJsonArray(this IEnumerable<sbyte> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (sbyte item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }

        public static JsonArray ToJsonArray(this IEnumerable<short> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (short item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }

        public static JsonArray ToJsonArray(this IEnumerable<string> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (string item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }

        public static JsonArray ToJsonArray(this IEnumerable<uint> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (uint item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }

        public static JsonArray ToJsonArray(this IEnumerable<ulong> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (ulong item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }

        public static JsonArray ToJsonArray(this IEnumerable<ushort> enumerable)
        {
            JsonArray jsonArray = new JsonArray();

            foreach (ushort item in enumerable)
            {
                jsonArray.Add(item);
            }

            return jsonArray;
        }
        #endregion
        #endregion
    }
}