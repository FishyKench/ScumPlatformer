using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{

    public Animator _anim;
    public Player _player;

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







        if (Input.GetButtonDown("Jump"))
        {
            if (_player.velocity.y > 0)
            {
            _anim.SetTrigger("isJumping");

            }
            else if (_player.velocity.y < -3.8)
            {
                _anim.SetBool("isFalling", true);
            }
            else
            {
                _anim.SetBool("isFalling", false);
            }

        }
    }
}
