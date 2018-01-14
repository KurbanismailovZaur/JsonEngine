using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Data.Json.Engine
{
    public interface IJsonValue
    {
        JsonType Category { get; }
        JsonDataType Type { get; }
    }
}