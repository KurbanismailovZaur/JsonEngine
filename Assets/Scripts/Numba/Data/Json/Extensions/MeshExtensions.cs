using Numba.Data.Json.Engine;
using Numba.Data.Json.Extentsions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Extensions
{
    public static class MeshExtensions
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
        public static JsonObject ToJsonObject(this Mesh mesh)
        {
            JsonObject jsonMesh = new JsonObject()
            {
                { "name", mesh.name },
                { "vertices", mesh.vertices.ToJsonArray() },
                { "colors", mesh.colors.ToJsonArray() },
                { "normals", mesh.normals.ToJsonArray() },
            };

            #region UVs
            int uvSetCount = GetUVSetsCount(mesh);

            JsonArray jsonUVSets = new JsonArray();
            List<Vector2> uvs = new List<Vector2>();

            for (int i = 0; i < uvSetCount; i++)
            {
                mesh.GetUVs(i, uvs);
                jsonUVSets.Add(uvs.ToJsonArray());
            }

            jsonMesh.Add("uvs", jsonUVSets);
            #endregion

            #region Triangles
            JsonArray jsonTriangles = new JsonArray();

            for (int i = 0; i < mesh.subMeshCount; i++)
            {
                int[] triangles = mesh.GetTriangles(i);
                jsonTriangles.Add(triangles.ToJsonArray());
            }

            jsonMesh.Add("triangles", jsonTriangles);
            #endregion

            return jsonMesh;
        }

        private static int GetUVSetsCount(Mesh mesh)
        {
            int i = 0;
            List<Vector2> uvs = new List<Vector2>();

            try
            {
                for (; i < 8; i++)
                {
                    mesh.GetUVs(i, uvs);
                }
            }
            catch (System.Exception) { }

            return i;
        }

        public static JsonArray ToJsonArray(this IEnumerable<Mesh> meshes)
        {
            JsonArray jsonMeshes = new JsonArray();
            foreach (Mesh mesh in meshes)
            {
                jsonMeshes.Add(mesh.ToJsonObject());
            }

            return jsonMeshes;
        }
        #endregion

        #region Event Handlers
        #endregion
        #endregion
    }
}