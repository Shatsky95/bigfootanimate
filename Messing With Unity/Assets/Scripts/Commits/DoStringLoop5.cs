using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoStringLoop5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        bool blue = false;
        do{
            print("the pen is not blue");
        }while(blue == true);

                string[] hamster = new string[3];
        hamster[0] = "first hamster";
        hamster[1] = "second hamster";
        hamster[2] = "third hamster";

        foreach(string animal in hamster){
            print(animal);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
