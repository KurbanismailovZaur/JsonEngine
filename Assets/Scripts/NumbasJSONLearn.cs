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
        JsonObject jObject = new JsonObject()
        {
            { "name", "Zaur" },
            { "age", 25 },
            { "married", true },
            { "car", new JsonObject() {
                { "brand", "Audi" } } },
            { "number", new JsonNumber(1234.56789f) },
            { "null", new JsonNull() }
        };

        string name = jObject["name"];
        int age = jObject["age"];
        bool married = jObject["married"];
        JsonObject car = jObject["car"];
        JsonNumber number = jObject["number"];
        JsonNull jNull = jObject["null"];

        jObject["name"] = "Zemfira";
        jObject["age"] = 24;
        jObject["married"] = "Yes";

        print(jObject);
    }
}