using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
public class playermovement : MonoBehaviour
{
    public static Action changedstateEvent;  
    public states states;
    public float movementSpeed;

    private float moveInputDirection;
    float jumpForce =128.0f ;
    private Rigidbody2D rb;
    bool isFacingRight = true;
    //because our char is already facing right by default
    //change to false if it is facing left by default



    private void Awake()
    {

        rb = GetComponent<Rigidbody2D>(); 
    }
    private void Start()
    {
        
        changecharstate(states.idle);
    }
    private void FixedUpdate()
    {
        ApplyMovement();
        statechangeofchar();
    }
    private void Update()
    {
        checkinput();
        CheckMovementDirection();
    }
    void checkinput()
    {

        moveInputDirection = Input.GetAxisRaw("Horizontal");

        if (Input.GetButton("Jump"))
        {
            Jump();
        }

        
    }

    private void statechangeofchar()
    {
        if (rb.velocity.x != 0 && rb.velocity.y == 0)
        {
            changecharstate(states.running);
        }
        else if (rb.velocity.y != 0)
        {
            changecharstate(states.jumping);
        }
        else if (rb.velocity == Vector2.zero)
        {
            changecharstate(states.idle);
        }
    }

    void ApplyMovement()
    {
       
      
        rb.velocity = new Vector2(movementSpeed * moveInputDirection, rb.velocity.y);
    }

    void CheckMovementDirection()
    {
        if(isFacingRight && moveInputDirection < 0)
        {
            Flip();
        }

        else if(!isFacingRight && moveInputDirection > 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0.0f, 180.0f, 0.0f);
    }

    void Jump()
    {
        
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    
    private void changecharstate(states s)
    {
        states = s;
        changedstateEvent?.Invoke();
    }

    #region Old Movement
    /* public void GetControlls()
     {
         RightArrow =  Input.GetKey(KeyCode.RightArrow);
         UpArrow = Input.GetKey(KeyCode.UpArrow);
         DownArrow =  Input.GetKey(KeyCode.DownArrow);
     }


     public void Update()
     {
         GetControlls();

         if(RightArrow && !UpArrow && !DownArrow)
         {
             transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z),1f);

         }
         else if(!RightArrow && UpArrow && !DownArrow)
         {

             rb.AddForce(Vector2.up*10, ForceMode2D.Impulse);

         }
         else if (!RightArrow && !UpArrow && DownArrow)
         {
             rb.AddForce(Vector2.down, ForceMode2D.Impulse);

         }
     }*/
    #endregion
}
