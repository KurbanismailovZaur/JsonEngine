using Numba.Data.Json.Engine;
using Numba.Data.Json.Engine.DataTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbasJSONLearn : MonoBehaviour
{
    private void Start()
    {
        JsonWrap jWrap = new JsonObject(@"{""name"":""Zaur"",""age"":25,""car"":{""brand"":""BMW"",""model"":""X6"",""owners"":[""Zemfira"",[""Ulia"", ""Alexandra""]]}}");
        print(jWrap["car"]["owners"][1][0]);
    }
}