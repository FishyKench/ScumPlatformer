using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallJumpPad : MonoBehaviour

{
    [Header("Variables")]
    [SerializeField] private float jumpSrrength;
    public bool isActive = true;

    [Header("References")]
    [SerializeField] GameObject particles;








    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().velocity.y += jumpSrrength;
            FindObjectOfType<AudioManager>().play("jumppad");
        }
    }


}


 