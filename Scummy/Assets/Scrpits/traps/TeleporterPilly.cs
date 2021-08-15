using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterPilly : MonoBehaviour
{
    [Header("References")]
    private Player _player;
    [SerializeField]
    private MeshCollider _mCollider;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _player.addScore();
            FindObjectOfType<AudioManager>().play("pillyPickup");
            FindObjectOfType<TeleporterRaiser>().AddPilly();
            Destroy(this.gameObject);

        }

    }
}
