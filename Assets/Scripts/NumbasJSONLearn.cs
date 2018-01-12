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
        JsonObject jObject = new JsonObject() { { "value", float.NaN } };
        print(jObject);

        string jsonBoolData = "true";
        JsonBool parsedBoolData = Json.Parse<JsonBool>(jsonBoolData);

        string jsonObjectData = "{\"name\":\"Zaur\",\"age\":25}";
        JsonObject parsedObjectData = Json.Parse<JsonObject>(jsonObjectData);

        string jsonArrayData = "[0,3.14,\"Hello Numba's JSON\",true,null,{\"name\":\"Zaur\"}]";
        JsonArray parsedArrayData = Json.Parse<JsonArray>(jsonArrayData);
    }
}