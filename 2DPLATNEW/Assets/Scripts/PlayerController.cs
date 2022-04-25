using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerStats")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;

    ///------------

    [Header("ground check")]
    private bool isGrounded;//are we on the ground/ can we jump
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private float moveVelocity;

    //////---------------
    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius,whatIsGround);
        //^^^^^   draws a radius, and sees if we are touching ground in that radius (from groundcheckposition, radius on layer of whatisground)

        moveVelocity =0f;//Non-stickplater

        if(Input.GetKey(KeyCode.D))
        {
          moveVelocity = speed;  
        }
        if(Input.GetKey(KeyCode.A))
        {
          moveVelocity = -speed;  
        }
        //move player left and Right
        rb.velocity= new Vector2(moveVelocity,rb.velocity.y);
        if(Input.GetKeyDown(KeyCode.Space)&&isGrounded)//only does it once, instead of sending player flying
       {
           Jump();
       } 
    }
    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);

    }
}
