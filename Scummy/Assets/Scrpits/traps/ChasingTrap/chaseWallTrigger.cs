using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseWallTrigger : MonoBehaviour
{
    public ChasingTrap chaseWall;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            chaseWall.shouldGo = true;
        }
    }
}
