﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
   
// player movement variables
   public float moveSpeed;
   public float jumpHeight;
   private bool doubleJump;
   //player grounded variables 
   private bool grounded; 
   public Transform groundCheck;
   public float groundCheckRadius;
   public LayerMask whatIsGround;

   public Vector3 scale;
   //non slide player
   private float moveVelocity;
   

   public Animator animator;

    // Start is called before the first frame update
    void Start()
    {  scale = transform.localScale;
        animator.SetBool("isWalking", false);
        animator.SetBool("isWalking", false);
        
    }
    void FixedUpdate(){
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }


    // Update is called once per frame
    void Update(){
        //moves player left and right
         moveVelocity = 0f;

    
        if(Input.GetKey(KeyCode.D)){
            //GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = moveSpeed;
            animator.SetBool("isWalking",true);
        }

        else if(Input.GetKeyUp (KeyCode.D)){
            animator.SetBool("isWalking",false);
        }
        else if(Input.GetKey(KeyCode.A)){
           // GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
           moveVelocity = -moveSpeed;
            animator.SetBool("isWalking",true);
        }
        else if(Input.GetKeyUp (KeyCode.A)){
            animator.SetBool("isWalking",false);
        }
            //makes player jump
        if(Input.GetKeyDown(KeyCode.W) && grounded )
        {
            Jump();}
        if(grounded){
            doubleJump = false;
            animator.SetBool("isJumping",false);
        }
        if(Input.GetKeyDown (KeyCode.W)&& !doubleJump && !grounded){
            Jump();
            doubleJump = true;
        }
            //non slider player
           
            GetComponent<Rigidbody2D>().velocity =  new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

    // make player flip
        if(GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(scale.x,scale.y,scale.z);

        else if(GetComponent<Rigidbody2D>().velocity.x < 0)
            transform.localScale = new Vector3(-scale.x,scale.y,scale.z);
            


}
    void Jump(){
         GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
         animator.SetBool("isJumping",true);

    }
}