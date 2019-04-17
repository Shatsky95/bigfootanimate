using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour{

    public int playerHealth = 100;
    public int currentHealth;

    Text Health;

    void Start (){
        currentHealth = playerHealth;
        Health = GetComponent<Text>();
    }
    

    
    

    // Update is called once per frame
    void Update(){
        Health.text = " " + currentHealth;
    

    }

    public void TakeDamage(int amount){
        currentHealth -= amount;
        if(currentHealth <= 0){
                currentHealth=0;
                print("GAME OVER");
        }
    }
        
    }

