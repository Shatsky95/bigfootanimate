using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPractice1 : MonoBehaviour{

    public string car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        switch(car){
            case "chevy":
            case "ford":
            case "buick":
            print("We all drive fast");
            break;
        }
        
    }
}
