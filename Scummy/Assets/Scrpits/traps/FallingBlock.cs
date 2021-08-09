using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour
{
    [SerializeField]
    public Rigidbody block;
    [SerializeField]
    private float _fallSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            block.useGravity = true;
            block.AddForce(Vector3.down * _fallSpeed);

        }
    }
}
