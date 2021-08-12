using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillyJumppad : MonoBehaviour
{
    [SerializeField] private float force;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("boing");
            other.GetComponent<Player>().velocity.y += force;
        }
    }
}
