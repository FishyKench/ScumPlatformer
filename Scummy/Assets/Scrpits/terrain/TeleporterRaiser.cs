using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterRaiser : MonoBehaviour
{

    [SerializeField]
    private int _pillyCount;
    [SerializeField]
    private bool isCollected;
    [SerializeField]
    private ParticleSystem particles;


    // Start is called before the first frame update
    void Start()
    {
        particles.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (_pillyCount == 2 && !isCollected )
        {
            onCollider();
        }
    }

    public void AddPilly()
    {
        _pillyCount += 1;
    }

    public void onCollider()
    {
        MeshCollider sc = gameObject.AddComponent(typeof(MeshCollider)) as MeshCollider;
        sc.convex = true;
        sc.isTrigger = true;
        isCollected = true;
        particles.Play();
    }
}

