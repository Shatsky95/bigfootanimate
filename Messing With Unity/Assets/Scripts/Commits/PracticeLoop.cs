using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        bool goodluck = false;
        do{
            print("you are gonna need it");
        }while(goodluck == true);

        string[] birds = new string[3];
        birds[0] = "first birds";
        birds[1] = "second birds";
        birds[2] = "third birds";

        foreach(string animal in birds){
            print(animal);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}