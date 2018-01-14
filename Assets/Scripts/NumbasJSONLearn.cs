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
        jObject["name"] = 0;
        jObject["name"] = 1;
        jObject["name"] = true;
        jObject.Add("age", 25);
        jObject.Add(new JsonField("married", true));
        jObject.Insert(1, "other", new JsonObject() { { "OTHER", "!!!" } });

        bool married = jObject["married"];

        print(jObject);
    }
}