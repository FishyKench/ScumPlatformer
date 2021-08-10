using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpikeAppear : MonoBehaviour
{

    public MeshRenderer spike;

    // Start is called before the first frame update
    void Start()
    {
        spike.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spike.enabled = true;
        }
    }
}
