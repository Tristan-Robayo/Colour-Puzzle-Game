using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vector3Extension
{
    public static class Vector3Extension
    {
        public static Vector3 RandomVector3Position(this Vector3 vec, float min, float max)
        {
            return new Vector3(Random.Range(min, max), Random.Range(min, max), Random.Range(min, max));
        }
    }
}
