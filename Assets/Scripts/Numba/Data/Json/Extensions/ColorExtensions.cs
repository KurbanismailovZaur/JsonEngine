using Numba.Data.Json.Engine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Extensions
{
    public static class ColorExtensions
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
        public static JsonObject ToJsonObject(this Color color)
        {
            return new JsonObject() { { "r", color.r }, { "g", color.g }, { "b", color.b }, { "a", color.a } };
        }

        public static JsonArray ToJsonArray(this IEnumerable<Color> colors)
        {
            JsonArray jsonColors = new JsonArray();
            foreach (Color color in colors)
            {
                jsonColors.Add(color.ToJsonObject());
            }

            return jsonColors;
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}