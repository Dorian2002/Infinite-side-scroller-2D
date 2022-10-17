using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private Animator anim;

    private void Start()
    {
        anim.SetBool("isRun",true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && body.velocity.y == 0)
        {
            body.AddForce(new Vector2(0,300));
            anim.SetBool("isJump",true);
        }
        else
        {
            anim.SetBool("isJump",false);
        }
    }
}
