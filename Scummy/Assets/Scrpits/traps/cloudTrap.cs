using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudTrap : MonoBehaviour
{
    public Transform cloud;
    public GameObject spike;
    [SerializeField] float minMaxPos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < 5; i++)
            {
                float randomPos = Random.Range(cloud.position.x + minMaxPos, cloud.position.x - minMaxPos);
                Instantiate(spike, new Vector3(randomPos, cloud.position.y, 0), Quaternion.Euler(90,0,0));
                Debug.Log("SPIKING");
                Debug.Log(i);
            }
        }
    }
}
