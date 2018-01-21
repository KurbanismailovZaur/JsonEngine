using Numba.Data.Json.Engine;
using Numba.Data.Json.Engine.DataTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbasJSONLearn : MonoBehaviour
{
    private void Start()
    {
        string s = new JsonString("\"Hello Numba\"", true).Value;
        bool b = new JsonBool("true").Value;
        int i = new JsonInt("1234567890").Value;
        char c = new JsonChar("\"#\"").Value;
        float f = new JsonFloat("3.14").Value;
        JsonNull nul = new JsonNull("null");
        JsonNumber num = new JsonNumber("1.234567890");

        print(num);
    }
}