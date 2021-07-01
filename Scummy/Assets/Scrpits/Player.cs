using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public CharacterController cController;
    [Header("Movement")]
    [SerializeField] private float _speed = 10.0f;

    [Header("Jumping")]
    [SerializeField] private float _gravity = -70.81f;
    [SerializeField] private float _jumpPwr = 5f;
    [SerializeField] private float _gcDelay = 0.5f;
    [SerializeField] private bool _secondChance = true;

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
            _secondChance = true;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        cController.Move(move * _speed * Time.deltaTime);


        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            velocity.y = Mathf.Sqrt(_jumpPwr * -2f * _gravity);
        }

        velocity.y += _gravity * Time.deltaTime;
        cController.Move(velocity * Time.deltaTime);


    }


}
