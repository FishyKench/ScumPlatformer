using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public CharacterController cController;
    [Header("Movement")]
    [SerializeField] private float _speed = 10.0f;

    [Header("Jumping")]
    [SerializeField] private float _gravity = -9.81f;
    [SerializeField] private float _jumpPwr = 5f;
    Vector3 velocity;


    [Header("Detection")]
    public Transform groundCheck;
    public float groundDistance = 0.4f;

    public LayerMask groundMask;
    bool isGrounded;

    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;

        }


        float x = Input.GetAxis("Horizontal");

        Vector3 move = -transform.right * x + transform.forward * 0;
        cController.Move(move * _speed * Time.deltaTime);


        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            velocity.y = Mathf.Sqrt(_jumpPwr * -3f * _gravity);
        }

        velocity.y += _gravity * Time.deltaTime;
        cController.Move(velocity * Time.deltaTime);


    }


}