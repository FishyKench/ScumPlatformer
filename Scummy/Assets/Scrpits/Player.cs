using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    [Header("References")]
    public CharacterController cController;


    [Header("Movement")]
    [SerializeField] private float _speed = 10.0f;

    [Header("Jumping")]
    [SerializeField] private float _gravity = -9.81f;
    [SerializeField] private float _jumpPwr = 5f;
    public Vector3 velocity;
    public CharacterAnim _cAnim;


    [Header("Detection")]
    public Transform groundCheck;
    public float groundDistance = 0.4f;

    [Header("Score")]
    private UiManager uimanager;
    public int score;
    public int maxScore;

    public LayerMask groundMask;
    bool isGrounded;

    [Header("Particles")]
    public GameObject jumpParticle;

    private void Awake()
    {
        uimanager = FindObjectOfType<UiManager>();
    }
    void Update()
    {
        if (velocity.y <= -50)
        {
            cController.Move(-Vector3.down * 10 * Time.deltaTime);
            Debug.Log("TOO MUCH VELOCITY");
        }

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }

        //if the player is grounded that means he isn't jumping and vice versa
        _cAnim.jumping = !isGrounded;

        _cAnim.xValue = Input.GetAxisRaw("Horizontal");

        _cAnim._anim.SetFloat("yVelocity",velocity.y / 2);


        float x = Input.GetAxis("Horizontal");

        Vector3 move = -transform.right * x + transform.forward * 0;
        cController.Move(move * _speed * Time.deltaTime);


        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            velocity.y = Mathf.Sqrt(_jumpPwr * -3f * _gravity);
            FindObjectOfType<AudioManager>().play("jump");
            Instantiate(jumpParticle, groundCheck);
        }

        velocity.y += _gravity * Time.deltaTime;
        cController.Move(velocity * Time.deltaTime);




    }
    public void addScore()
    {
        score++;
        uimanager.UpdateScore(score);
    }
}