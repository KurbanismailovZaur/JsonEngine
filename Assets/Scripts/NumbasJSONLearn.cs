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

        jObject.Add(new JsonField("name", "Zaur"));
        jObject.Add("age", 25);
        jObject.Insert(1, "married", true);
        jObject.Remove("age");

        JsonField nameField = jObject.GetField("married");
        nameField.Name = "age";
        nameField.Value = 25;

        jObject["wife"] = new JsonObject()
        {
            { "name", "Zemfira" },
            { "age", 24 }
        };

        string name = jObject.GetString("name");
        int age = jObject.GetInt("age");

        JsonObject wife = jObject.GetObject("wife");
        wife.Add("married", true);

        print(jObject);

        string wifeName1 = jObject.GetObject("wife").GetString("name");

        for (int i = 0; i < jObject.Count; i++)
        {
            // Do stuff..
        }

        foreach (JsonField field in jObject)
        {
            // Do stuff..
        }
    }
}