using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Switch5 : MonoBehaviour{

    public string person;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        switch(person){
            case "Monty":
                print("I worked a porter shift down at the resturaunt");
            break;
            case "Tyana":
                print("I actually did my homework today");
            break;
            case "Sherri":
                print("I did an endoscopy on this crazy patient");
            break;
            case "Justin":
                print("I ran 14 miles today");
            break;
            default:
                print("Ive never experienced that"+person+"!");
            break;

        }
        
    }
}
