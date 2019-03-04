using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Switch10 : MonoBehaviour{

    public string person;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        switch(person){
            case "Eric":
            case "Mo":
            case "johnny":
            print("I was at the movies with my friends");
            break;
        }
        
    }
}
