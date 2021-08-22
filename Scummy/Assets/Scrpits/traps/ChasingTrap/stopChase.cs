using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopChase : MonoBehaviour
{
    public ChasingTrap chasingWall;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            chasingWall.stopChase();
        }
    }
}
