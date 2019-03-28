using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoStringLoop2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        bool youareawesome = false;

        do{
            print("everything is cool");
            
        }while(youareawesome == true);

        string[] cat = new string[3];
        cat[0] = "first cat";
        cat[1] = "second cat";
        cat[2] = "third cat";

        foreach(string animal in cat){
            print(animal);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
