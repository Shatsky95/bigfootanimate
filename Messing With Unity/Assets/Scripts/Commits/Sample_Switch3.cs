using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Switch3 : MonoBehaviour{

    public string person;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        switch(person){
            case "Monty":
                print("I love american Idol");
            break;
            case "Tyana":
                print("omg I love instagram so much");
            break;
            case "Sherri":
                print("Have you seen all these marco polo videos");
            break;
            default:
                print("Ive never met "+person+"!");
            break;

        }
        
    }
}
