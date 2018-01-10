using Numba.Data.Json.Engine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Extensions
{
    public static class ShaderExtensions
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
        public static JsonObject ToJsonObject(this Shader shader)
        {
            return new JsonObject() { { "name", shader.name } };
        }

        public static JsonArray ToJsonArray(this IEnumerable<Shader> shaders)
        {
            JsonArray jsonShaders = new JsonArray();
            foreach (Shader shader in shaders)
            {
                jsonShaders.Add(shader.ToJsonObject());
            }

            return jsonShaders;
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}