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
        JsonObject jObject = new JsonObject();
        jObject["name"] = "Zaur";
        jObject["age"] = 25;

        string name = jObject["name"];
        int age = jObject["age"];

        print(jObject);
    }
}