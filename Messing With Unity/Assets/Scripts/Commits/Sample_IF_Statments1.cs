using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_IF_Statments1 : MonoBehaviour
{
    public string IsRunning;
    public bool MarathonRunner = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(IsRunning == "tired"){
            if(MarathonRunner){
                print("You got this!");
            }
            else{
                print("I am so done with running. I'm going to die.");
            }
        }
    else if(IsRunning == "sick"){
            if(MarathonRunner){
                print("I don't feel sick.");
            }
            else{
                print("I feel like I'm gonna barf.");
            }
        }
    else if (IsRunning == "good"){
            if(MarathonRunner){
                print("I feel fantabulous!");
            }
            else{
                print("I'm feeling like a party animal!");
            }
        }
    else{
        print("I don't know what you are talking about.");
    }
    }
}
