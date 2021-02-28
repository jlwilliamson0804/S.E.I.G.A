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
    

    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal"); //get input of x axis
        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }

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
