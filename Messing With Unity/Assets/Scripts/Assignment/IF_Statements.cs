using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_Statements : MonoBehaviour {

    public string stopLight; 
    public bool isUtahn = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(stopLight == "Red"){
            if(isUtahn){
                print("STOP! The Light is RED!");
            }
            else{
                print("Thank you for stopping!");
            }
        }
        else if(stopLight == "Yellow"){
            if(isUtahn){
                print("You've got this brah!");
        }
            else{
                print("thank you for yielding");
            }
        }
        else if(stopLight == "Green" && isUtahn){
            print("check phone, turn up radio sit at the light until almost yellow, then go");
        }
        else{
            print("Sorry you are driving in Utah!");
        }
    }
}