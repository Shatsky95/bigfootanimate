using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Switch9 : MonoBehaviour{

    public string person;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        switch(person){
            case "Monty":
                print("The deal is done on wednesday");
            break;
            case "Tyana":
                print("I am just so cool with all my makeup");
            break;
            case "Sherri":
                print("the frontrunner was packed today");
            break;
            case "Dylan":
                print("I played hoops at BYU all day today");
            break;
            default:
                print("I Heard about that"+person+"!");
            break;

        }
        
    }
}
