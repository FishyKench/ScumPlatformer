using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeNoDestroy : MonoBehaviour
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
        if (other.tag == "Player")
        {
            //Destroy(other.gameObject);
            other.GetComponent<Player>().Death();
            //Destroy(this.gameObject);
            if (transform.position.z == 0.25)
            {
                //Destroy(this.gameObject);
            }
        }
    }
}
