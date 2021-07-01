using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public CharacterController cController;

    private float _speed = 10.0f;
    private float _gravity = -50.81f;
    private float _jumpPwr = 5f;

    Vector3 velocity;



    public Transform groundCheck;
    public float groundDistance = 0.4f;

    public LayerMask groundMask;
    bool isGrounded;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        cController.Move(move * _speed * Time.deltaTime);


        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(_jumpPwr * -2f * _gravity);
        }



        velocity.y += _gravity * Time.deltaTime;
        cController.Move(velocity * Time.deltaTime);


    }

}
