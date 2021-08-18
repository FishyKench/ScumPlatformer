using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillyCount : MonoBehaviour
{
    private TeleporterRaiser _tpRaiser;

    // Start is called before the first frame update
    void Start()
    {
        _tpRaiser = FindObjectOfType<TeleporterRaiser>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _tpRaiser.AddPilly();
            Destroy(this.gameObject);
        }
    }
}
