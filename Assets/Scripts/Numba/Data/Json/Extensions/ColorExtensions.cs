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

        #region Constructors
        #endregion

        #region Methods
        public static JsonObject ToJsonObject(this Color color)
        {
            return new JsonObject()
            {
                { "r", color.r },
                { "g", color.g },
                { "b", color.b },
                { "a", color.a }
            };
        }
        #endregion

        #region Indexers
        #endregion

        #region Events handlers
        #endregion
        #endregion
    }
}