using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingPlatform : MonoBehaviour
{
    [SerializeField] float _xrotAmount;
    [SerializeField] float _yrotAmount;
    [SerializeField] float _zrotAmount;
    private void FixedUpdate()
    {
        gameObject.transform.Rotate(_xrotAmount, _yrotAmount, _zrotAmount);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           Destroy(other.gameObject);
        }
    }
}
