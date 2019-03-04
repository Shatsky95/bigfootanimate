using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Switch8 : MonoBehaviour{

    public string person;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        switch(person){
            case "Monty":
                print("I read an awesome book");
            break;
            case "Tyana":
                print("I washed the mountain of clothes I have");
            break;
            case "Sherri":
                print("I made cookies like I always do on sunday");
            break;
            case "Justin":
                print("I watched a star is born with my wife haley");
            break;
            default:
                print("I Watched Tv"+person+"!");
            break;

        }
        
    }
}
