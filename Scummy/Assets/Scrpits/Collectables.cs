using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    [Header("References")]
    private Player _player;
    [SerializeField]
    private AudioClip _pickUpAudio;
    [SerializeField]
    private AudioSource _audioSource;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _player.addScore();
            _audioSource.Play();
            Destroy(this.gameObject);
            
        }
        else
        {
            Debug.Log("notplayer");
        }

    }
}
