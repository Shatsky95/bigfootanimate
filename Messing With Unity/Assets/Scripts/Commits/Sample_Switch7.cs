using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Switch7 : MonoBehaviour{

    public string person;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        switch(person){
            case "Kade":
                print("That english homework was intense");
            break;
            case "Brad":
                print("I hate math im never gonna use this stuff in real life");
            break;
            case "James":
                print("I think astronomy is such a cool subject");
            break;
            case "Ezra":
                print("Why is PE class still a thing");
            break;
            default:
                print("I think thats awesome"+person+"!");
            break;

        }
        
    }
}
