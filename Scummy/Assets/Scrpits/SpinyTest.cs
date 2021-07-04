using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinyTest : MonoBehaviour
{
    void Update()
    {

        float z = Mathf.PingPong(t: Time.time, length: 1f);
        Vector3 axis = new Vector3(x: -1, y: 0, z: 0);
        transform.Rotate(axis, angle: 1f);
    }
}