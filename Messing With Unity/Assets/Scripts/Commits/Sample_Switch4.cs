using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Switch4 : MonoBehaviour{

    public string person;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        switch(person){
            case "Taylor":
                print("My favorite book is harry potter and the deathly hallows");
            break;
            case "Colt":
                print("My favorite book is IT by Stephen King");
            break;
            case "Braden":
                print("I dont know how to read");
            break;
            default:
                print("who is this person "+person+"!");
            break;

        }
        
    }
}
