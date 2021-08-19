using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnyCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float z = Mathf.PingPong(t: Time.time , length: 1f);
        Vector3 axis = new Vector3(x: 1, y: 1, z: 1);
        transform.Rotate(axis, angle: 1);
    }
}
