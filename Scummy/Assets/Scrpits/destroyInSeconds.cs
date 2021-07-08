using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyInSeconds : MonoBehaviour
{
    [SerializeField] private float timeUntilDestroy;
    private void Start()
    {
        Destroy(gameObject, timeUntilDestroy);
    }
}
