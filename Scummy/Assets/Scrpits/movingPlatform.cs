using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    [SerializeField] Transform _pos1, _pos2;
    [SerializeField] float _speed;
    [SerializeField] Transform _StartPos;

    Vector3 nextPos;

    private void Start()
    {
        nextPos = _StartPos.position;
    }

    private void Update()
    {
        if (transform.position == _pos1.position)
        {
            nextPos = _pos2.position;
        }
        if(transform.position == _pos2.position)
        {
            nextPos = _pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, _speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(_pos1.position, _pos2.position);
    }
}
