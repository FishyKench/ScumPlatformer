using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlatform : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private GameObject _killPlatform;

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
        yield return new WaitForSeconds(1.3f);
        Destroy(this.gameObject);
      
    }
}
