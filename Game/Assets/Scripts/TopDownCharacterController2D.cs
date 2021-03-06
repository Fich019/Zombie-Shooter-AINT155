﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController2D : MonoBehaviour {

    public float speed = 5.0f;
    Rigidbody2D rigidbody2D;

    bool playerWalking;
    Animator animator;
    SpriteRenderer spriterender;

    // Use this for initialization
    void Start () {

        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

     void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rigidbody2D.velocity = new Vector2(x, y) * speed;
        rigidbody2D.angularVelocity = 0.0f;

        spriterender = GetComponent<SpriteRenderer>();
        if (x < 0)
        {
            spriterender.flipX = true;

        }
        else if (x > 0)
        {
            spriterender.flipX = false;
        }



        if ((x != 0) || (y != 0))
        {
            playerWalking = true;
            animator.SetBool("playerWalking", playerWalking);

        }
        else
        {

            playerWalking = false;
            animator.SetBool("playerWalking", playerWalking);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
