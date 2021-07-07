using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{

    public Animator _anim;
    public Player _player;
    

    public bool jumping = false;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        _player = GetComponent<Player>();
    }

    // Update is called once per frame
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
    }

    public void jump()
    {
        _anim.SetBool("isJumping", true);
    }

    public void stopJump()
    {
        _anim.SetBool("isJumping", false);
    }
}
