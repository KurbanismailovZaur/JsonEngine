using Numba.Data.Json.Engine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Extensions
{
    public static class QuaternionExtensions
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
        public static JsonObject ToJsonObject(this Quaternion quaternion)
        {
            return new JsonObject()
            {
                { "x", quaternion.x },
                { "y", quaternion.y },
                { "z", quaternion.z },
                { "w", quaternion.w }
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