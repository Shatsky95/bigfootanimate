using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoStringLoop4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        bool dog = false;
        do{
            print("that is a cat");

        }while(dog == true);

                string[] fish = new string[3];
        fish[0] = "first fish";
        fish[1] = "second fish";
        fish[2] = "third fish";

        foreach(string animal in fish){
            print(animal);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
