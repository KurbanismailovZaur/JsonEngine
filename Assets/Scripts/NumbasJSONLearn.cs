using Numba.Data.Json.Engine;
using Numba.Data.Json.Engine.DataTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbasJSONLearn : MonoBehaviour
{
    private void Start()
    {
        JsonObject jObject = new JsonObject()
        {
            { "float", "NaN" },
            { "double", "Infinity" }
        };

        print(jObject.GetFloat("float"));
        print(jObject.GetDouble("double"));

        print(jObject.GetFloat("double"));
    }
}