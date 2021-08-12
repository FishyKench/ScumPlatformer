using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandTrap : MonoBehaviour
{
    public Transform pos2;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (other.CompareTag("Player"))
        {
            pos2.position = new Vector3(pos2.position.x, pos2.position.y, pos2.position.z + 1);
        }
    }
    
}
