using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallJumpPad : MonoBehaviour

{
    [Header("Variables")]
    [SerializeField] private float jumpSrrength;






    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().velocity.y += jumpSrrength;
        }
    }

}



