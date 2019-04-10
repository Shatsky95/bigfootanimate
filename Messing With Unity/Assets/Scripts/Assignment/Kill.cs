using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour{
    public LevelManager levelManager;
    //use this for intialization
    void Start (){
         levelManager = FindObjectOfType <LevelManager>();
    }

   void OnTriggerEnter2D(Collider2D other){
       if(other.tag == "Player"){
           levelManager.RespawnPlayer();
       }
             }
}
