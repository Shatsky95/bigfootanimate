using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Switch2 : MonoBehaviour{

    public string person;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        switch(person){
            case "Monty":
                print("Im watching shark tank");
            break;
            case "Tyana":
                print("Im in my room on facebook like usual");
            break;
            case "Sherri":
                print("Im making you a pizza like you wanted");
            break;
            default:
                print("Ive never met "+person+"!");
            break;

        }
        
    }
}
