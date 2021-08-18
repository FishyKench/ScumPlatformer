using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlatform : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rb.isKinematic = false;
            DestroyPlatformCoroutine();

        }
    }


    public void DestroyPlatformCoroutine()
    {
        StartCoroutine(DestroyPlatform());
    }


    IEnumerator DestroyPlatform()
    {
        yield return new WaitForSeconds(2f);
        this.transform.position = new Vector3(0, 0.39f, 0);
        rb.isKinematic = true;

    }
}
