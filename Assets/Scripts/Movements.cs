using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private Animator anim;
    private GameManager gm;
    private bool canJump;

    private void Start()
    {
        gm = GetComponentInParent<GameManager>();
        anim.SetBool("isRun",true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            canJump = false;
            body.AddForce(new Vector2(0,300));
            anim.SetBool("isJump",true);
        }

        if (canJump && transform.position.x <= -15)
        {
            transform.Translate(new Vector3(1,0,0));
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Platform") && canJump == false)
        {
            gm.UpScore();
            anim.SetBool("isJump",false);
            canJump = true;
        }
    }
}
