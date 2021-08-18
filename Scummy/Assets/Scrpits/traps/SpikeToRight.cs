using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeToRight : MonoBehaviour
{
    [SerializeField]
    public Rigidbody block;
    [SerializeField]
    private float _speed;

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
            block.AddForce(Vector3.right * _speed * Time.deltaTime, ForceMode.Impulse);
            Destroy(this.gameObject);
        }
    }
}
