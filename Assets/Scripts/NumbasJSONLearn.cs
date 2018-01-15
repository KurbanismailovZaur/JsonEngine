using Numba.Data.Json.Engine;
using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Extentions;
using Numba.Data.Json.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbasJSONLearn : MonoBehaviour
{
    private void Start()
    {
        JsonObject jObject = new JsonObject
        {
            { "name", "Zaur" },
            { "age", 25 },
            { "married", true },
            {
                "address",
                new JsonObject() {
            { "street", "Shodnenskaya" },
            { "house", 1 } }
            },
            { "parents", new JsonArray() { "Papa", "Mama" } }
        };

        JsonArray jArray = new JsonArray() { 0, 1, 1, 2 };
        jArray.Remove((JsonValue)new JsonInt(1));

        print(jArray);
    }
}