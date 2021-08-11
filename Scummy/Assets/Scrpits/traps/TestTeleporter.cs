using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTeleporter : MonoBehaviour
{
    public GameObject player;
    public Transform location;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = location.transform.position;
            Physics.SyncTransforms();
        }
    }
}
