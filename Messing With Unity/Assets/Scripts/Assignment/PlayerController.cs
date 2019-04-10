﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
   
// player movement variables
   public float moveSpeed;
   public float jumpHeight;
   //player grounded variables 
   private bool grounded; 
   public Transform groundCheck;
   public float groundCheckRadius;
   public LayerMask whatIsGround;

   public Vector3 scale;

    // Start is called before the first frame update
    void Start()
    {  scale = transform.localScale;
        
    }
    void FixedUpdate(){
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }


    // Update is called once per frame
    void Update(){
        //moves player left and right

    
        if(Input.GetKey(KeyCode.D)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else if(Input.GetKey(KeyCode.A)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
            //makes player jump
        if(Input.GetKeyDown(KeyCode.W) && grounded ){
            Jump();
    }// make player flip
        if(GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(scale.x,scale.y,scale.z);

        else if(GetComponent<Rigidbody2D>().velocity.x < 0)
            transform.localScale = new Vector3(-scale.x,scale.y,scale.z);
            


}
    void Jump(){
         GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);

    }
}