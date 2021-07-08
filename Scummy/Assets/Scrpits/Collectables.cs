using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    [Header("References")]
    private Player _player;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _player.addScore();
            FindObjectOfType<AudioManager>().play("pillyPickup");
            Destroy(this.gameObject);
            
        }
        else
        {
            Debug.Log("notplayer");
        }

    }
}
