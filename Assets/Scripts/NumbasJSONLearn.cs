using Numba.Data.Json.Engine;
using Numba.Data.Json.Engine.DataTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbasJSONLearn : MonoBehaviour
{
    private void Start()
    {
        JsonObject jObject = new JsonObject();
        jObject.Add("name", "Zaur");
        jObject.InsertOrAppend(2, "age", 25);
        jObject[2] = new JsonField("married", true);
        jObject["married"] = null;

        JsonArray jArray = new JsonArray() { 0, 1, '#', "Name", jObject};
        jArray.Remove(jObject);

        List<object> ints = new List<object>() { 0, null };
        //ints.Remove(0);

        print(jArray.Count);
    }
}