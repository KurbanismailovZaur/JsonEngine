using Numba.Data.Json.Engine;
using Numba.Data.Json.Engine.DataTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbasJSONLearn : MonoBehaviour
{
    private void Start()
    {
        string jsonData = "{\"name\":\"Zaur\",\"age\":25,\"cars\":[\"Audi\",\"Jaguar\"]}";

        JsonObject jObject = Json.Parse<JsonObject>(jsonData);
        int age = jObject.GetNumber("age").ToInt();

        print(age);
    }
}