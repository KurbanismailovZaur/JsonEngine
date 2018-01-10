using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine.DataTypes
{
    public interface IJsonDataType { }

    public interface IJsonDataType<T> : IJsonDataType
    {
        T Value { get; set; }
    }
}