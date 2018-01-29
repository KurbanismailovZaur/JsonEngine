using Numba.Data.Json.Engine;
using Numba.Data.Json.Engine.DataTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbasJSONLearn : MonoBehaviour
{
    private void Start()
    {
        JsonWrap jWrap = new JsonWrap(new JsonObject());
        jWrap.AddField("name", "Zaur");

        // Rename HasField to HasFieldWithName
        print(jWrap.HasFieldWithNane("name"));

        jWrap = new JsonArray() { 0, 1f, 2d, 3m, '4', "5" };

        print(jWrap.GetDecimal(3));
    }
}