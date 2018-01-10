using Numba.Data.Json.Engine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Extensions
{
    public static class TransformExtensions
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
        public static JsonObject ToJsonObject(this Transform transform)
        {
            return new JsonObject()
            {
                { "position", transform.position.ToJsonObject() },
                { "localPosition", transform.localPosition.ToJsonObject() },
                { "rotation", transform.rotation.ToJsonObject() },
                { "localRotation", transform.localRotation.ToJsonObject() },
                { "lossyScale", transform.lossyScale.ToJsonObject() },
                { "localScale", transform.localScale.ToJsonObject() }
            };
        }

        public static JsonArray ToJsonArray(this IEnumerable<Transform> transforms)
        {
            JsonArray jsonTransforms = new JsonArray();
            foreach (Transform transform in transforms)
            {
                jsonTransforms.Add(transform.ToJsonObject());
            }

            return jsonTransforms;
        }
        #endregion
        #endregion
    }
}