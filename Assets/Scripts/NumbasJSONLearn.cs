using Numba.Data.Json.Engine;
using Numba.Data.Json.Engine.DataTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbasJSONLearn : MonoBehaviour
{
    private void Start()
    {
        JsonObject jObject = new JsonObject() { { "name", "Zaur" } };
        string name = jObject.GetString("name");

        JsonArray jArray = new JsonArray() { 0, 1f, 2d, 3m, '#', "Numba" };
        char symbol = jArray.GetChar(4);

        JsonWrap jWrap = new JsonObject() { { "name", "Zaur" } };
        string wrapName = jWrap["name"][0];
        //JsonWrap jWrap = new JsonArray() { new JsonObject() { { "name", "Zaur" } }, 1, 2, 3m };
        //jWrap[0] = '#';

        print(symbol);
    }
}