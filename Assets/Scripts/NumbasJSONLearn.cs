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
        JsonString jString = "Zaur";
        JsonInt jInt = 25;
        JsonBool jBool = true;

        JsonField nameField = new JsonField("name", jString);

        JsonObject jObject = new JsonObject
        {
            nameField,
            { "age", jInt },
            { "married", jBool }
        };

        jObject.Add("values", new JsonArray() { 0, 1f, 2d, 3m, '#', "abc", new JsonObject() });
        jObject.Insert(0, "isman", true);
        jObject.SwapFields(0, 1);
        //jObject.InsertOrAppend(16, null);

        print(jObject);
    }
}