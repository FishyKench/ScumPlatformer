using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTpBack : MonoBehaviour
{



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
          other.gameObject.transform.position = new Vector3(10, 10, 10);
            Debug.Log("TF U ON");
        }
    }

}
