using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCube : MonoBehaviour
{
    timer timer;

    private void Start()
    {
        timer = FindObjectOfType<timer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // WIN !
            timer.onWin();
        }
    }
}
