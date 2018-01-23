using Numba.Data.Json.Engine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Extensions
{
    public static class Vector4Extensions
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
        public static JsonObject ToJsonObject(this Vector4 vector4)
        {
            return new JsonObject()
            {
                { "x", vector4.x },
                { "y", vector4.y },
                { "z", vector4.z },
                { "w", vector4.w}
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