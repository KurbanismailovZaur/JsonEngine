using Numba.Data.Json.Engine;
using Numba.Data.Json.Engine.DataTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbasJSONLearn : MonoBehaviour
{
    private void Start()
    {
        JsonBool jBool = true;
        JsonNull jNull = null;
        JsonNumber jNumber = 3.14d;

        JsonField jfield = new JsonField("bool", new JsonNumber(3.14m));
        print(jfield);

        JsonObject jObject = new JsonObject() { jfield, { "null", jNull }, { "number", jNumber } };
        jObject.Add("name", null);
        jObject["surname"] = '#';

        JsonArray jArray = new JsonArray();
        jArray[2] = 4;

        print(jObject);
    }
}