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
            { "number", new JsonNumber("1234.5678") },
            { "null", new JsonNull() }
        };

        string name = (string)jObject["name"];
        int? age = (int?)jObject["age"];
        bool? married = (bool?)jObject["married"];
        JsonObject car = (JsonObject)jObject["car"];
        JsonNumber number = (JsonNumber)jObject["number"];
        JsonNull jNull = (JsonNull)jObject["null"];

        JsonField<IJsonValue> jField = new JsonField<IJsonValue>("", null);
        print(jField.Value );
    }
}