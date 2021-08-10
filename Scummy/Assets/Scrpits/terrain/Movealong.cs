using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movealong : MonoBehaviour
{
    [SerializeField] public GameObject player;
    //[SerializeField] float flwspeed = 1.0f;
    public CharacterController ccController;
    bool contact = false;

    Vector3 PrevPos;
    Vector3 NewPos;
    Vector3 ObjVelocity;
    private void Start()
    {
        PrevPos = transform.position;
        NewPos = transform.position;
    }
    void FixedUpdate()
    {
        NewPos = transform.position;
        ObjVelocity = (NewPos - PrevPos) / Time.fixedDeltaTime;
        PrevPos = NewPos;
    }

    void Update()
    {


        if (contact == true)
        {


            ccController.Move(ObjVelocity * Time.deltaTime);
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == player)
        {

            contact = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            contact = false;
        }
    }
}
