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
        JsonBool jBool1 = new JsonBool(true);
        JsonBool jBool2 = true;

        JsonField jField1 = new JsonField("name", new JsonString("Zaur"));
        JsonField jFeidl2 = new JsonField("name", "Zaur");

        JsonObject jObject = new JsonObject();

        jObject.Add(jField1);

        jObject.Add("age", new JsonInt(25));
        jObject.Add("age", (JsonValue)25);

        JsonField jField3 = jObject[0];
        jObject[0] = jField3;

        JsonValue jValue1 = jObject["name"];
        jObject["name"] = jValue1;
        jObject["name"] = new JsonBool(true);
        jObject["name"] = true;
        jObject["age"] = 25;

        print("");
    }
}