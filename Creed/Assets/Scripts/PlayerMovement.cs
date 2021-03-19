﻿/* 
 * Project: Creed and the Vow of Vengeance
 * Joseph W. Alex A. Cameron O. Kheta K.
 * Description: This script allows for our character to 
 *      move, and to know when on the ground
 * Date: February 2021
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;
    public float jumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayers;
    float mx; //movement along x-axis
    public Animator animator;

    private void Update()
    {
        
        mx = Input.GetAxisRaw("Horizontal"); //get input of x axis
        //animator.SetFloat("Speed", Mathf.Abs(mx));
        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
            
        }
        if(Mathf.Abs(mx) > 0.05f)
        {
            animator.SetBool("isRunning", true);

        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        animator.SetBool("isGrounded", IsGrounded());
    }

    

    private void FixedUpdate()
    {
        //allows us to move the player
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

        rb.velocity = movement;
    }

    //allows our player to jump
    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
        rb.velocity = movement;
        
    }

    //must be touching the ground to be able to jump
    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);
        

        if(groundCheck != null)
        {
            
            return true;
        }
        return false;
    }

}
