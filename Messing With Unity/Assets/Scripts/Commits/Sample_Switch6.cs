using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Switch6 : MonoBehaviour{

    public string person;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        switch(person){
            case "Monty":
                print("What is wrong with the human race people are so stupid");
            break;
            case "Tyana":
                print("Omg I am just the bees knees");
            break;
            case "Sherri":
                print("Did you go to the hospital today and get your blood work done");
            break;
            case "Justin":
                print("I helped a guy with his pacemaker today and it was very cool");
            break;
            default:
                print("I dont absolute nothing today"+person+"!");
            break;

        }
        
    }
}
