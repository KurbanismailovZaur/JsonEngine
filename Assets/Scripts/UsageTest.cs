using Numba.Data.Json.Engine;
using Numba.Data.Json.Engine.DataTypes;
using Numba.Data.Json.Engine.Extentions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsageTest : MonoBehaviour
{
    #region Entities
    #region Enums
    #endregion

    #region Delegates
    #endregion

    #region Structures
    #endregion

    #region Classes
    #endregion

    #region Interfaces
    #endregion
    #endregion

    #region Fields
    #endregion

    #region Events
    #endregion

    #region Behaviour
    #region Properties
    #endregion

    #region Constructors
    #endregion

    #region Methods
    private void Start()
    {
        JsonObject jObject = new JsonObject()
        {
            { "fieldName", "value" },
            { "fieldName2", 1 },
            { "fieldName3", true }
        };

        bool value = jObject.GetField("fieldName3").BaseValue.As<JsonBool>().Value.Value;
        bool value2 = jObject["fieldName3"].AsBool().Value;
        bool value3 = jObject.GetBool("fieldName3").Value;

        print(value3);
    }
    #endregion

    #region Events handlers
    #endregion
    #endregion
}