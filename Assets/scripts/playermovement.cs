using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    public float movementSpeed;

    private float moveInputDirection;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        ApplyMovement();
    }
    private void Update()
    {
        checkinput();
    }
    void checkinput()
    {
        moveInputDirection = Input.GetAxisRaw("Horizontal");
    }

    void ApplyMovement()
    {
        rb.velocity = new Vector2(movementSpeed * moveInputDirection, rb.velocity.y);
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
