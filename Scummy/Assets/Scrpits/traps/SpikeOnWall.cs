using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeOnWall : MonoBehaviour
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
            other.GetComponent<Player>().Death();
            block.AddForce(Vector3.left * _speed);
            Destroy(this.gameObject);
        }
    }
}
