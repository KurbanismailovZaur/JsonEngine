using Numba.Data.Json.Engine;
using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Extentions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbasJSONLearn : MonoBehaviour
{
    private void Start()
    {
        JsonObject jObject = new JsonObject() { { "int", 1 } };
        jObject.SetInt("int", null);
        string jsonData = jObject.ToString();
        print(jsonData);

        JsonObject parsedJObject = Json.Parse<JsonObject>(jsonData);
        print(parsedJObject);

        if (parsedJObject.IsNullField("int"))
        {
            Debug.Log("Sorry, field with name \"int\" is null");
        }
        else
        {
            int value = parsedJObject.GetNumber("int").ToInt();
        }
    }
}