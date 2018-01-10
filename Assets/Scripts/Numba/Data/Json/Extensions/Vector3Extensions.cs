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

        #region Methods
        public static JsonObject ToJsonObject(this Vector3 vector)
        {
            return new JsonObject() { { "x", vector.x }, { "y", vector.y }, { "z", vector.z } };
        }

        public static JsonArray ToJsonArray(this IEnumerable<Vector3> vectors)
        {
            JsonArray jsonVectors = new JsonArray();
            foreach (Vector3 vector in vectors)
            {
                jsonVectors.Add(vector.ToJsonObject());
            }

            return jsonVectors;
        }
        #endregion
        #endregion
    }
}