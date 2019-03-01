using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Switch1 : MonoBehaviour {

    public string character;





    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){  
        switch(character){
            case "John":
                print("I was eating lunch");
            break;
            case "Brad":
                print("I was drinking coffee at starbucks");
            break;
            case "Zack":
                print("I was just being lazy as usual");
            break;
            default:
                print("Ive never met "+character+"!");
            break;
        }    
    }
}

