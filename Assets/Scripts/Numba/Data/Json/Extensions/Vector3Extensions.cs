using Numba.Data.Json.Engine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Extensions
{
    public static class Vector3Extensions
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
        public static JsonObject ToJsonObject(this Vector3 vector3)
        {
            return new JsonObject()
            {
                { "x", vector3.x },
                { "y", vector3.y },
                { "z", vector3.z }
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