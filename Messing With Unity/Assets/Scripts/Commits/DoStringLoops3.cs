using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoStringLoops3 : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){
        bool hello = false;
        do{
            print("goodbye");

        }while(hello == true);


                string[] snake = new string[3];
        snake[0] = "first snake";
        snake[1] = "second snake";
        snake[2] = "third snake";

        foreach(string animal in snake){
            print(animal);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
