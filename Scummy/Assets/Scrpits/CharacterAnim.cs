using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    [Header("References")]
    public Animator _anim;
    public Player _player;

    [Header("variables")]
    public bool jumping = false;
    public float xValue;
    [SerializeField] private float _rotSpeed;

    void Start()
    {
        _anim = GetComponent<Animator>();
        _player = GetComponent<Player>();
    }

    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            _anim.SetBool("isWalking", true);
        }
        else
        {
            _anim.SetBool("isWalking", false);
        }

        //if the player is jumping play the matching animation and vice versa
        if (jumping) jump();
        else if (!jumping) stopJump();


        if (xValue < 0) rotateLeft();
        else if (xValue > 0) rotateRight();
    }

    //jumping
    public void jump()
    {
        _anim.SetBool("isJumping", true);
    }

    public void stopJump()
    {
        _anim.SetBool("isJumping", false);
    }

    //rotating with movement direction
    public void rotateLeft()
    {
        
    }

    public void rotateRight()
    {
        
    }
}
