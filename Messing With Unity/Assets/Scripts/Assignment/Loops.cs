using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
    public int bottles = 100;
    public bool isRaining = true;

    // Start is called before the first frame update
    void Start() {
        //do while loop
        // bool shouldContinue = false;

        // do{
        //     print("Hello World");
        // }while(shouldContinue == true);

        
        //For loop
        //  for(int i=0; i < bottles; i++){
        //      print(i +"bottles of beer on the wall");
        //  }
        
        //  while(bottles <= 100){
        //     print(bottles +"bottles of ginger beer on the wall");
        // }
        //For Each Loop

        string[] strings = new string[3];

        strings[0] = "first string";
        strings[1] = "second string";
        strings[2] = "third string";

        foreach(string item in strings){
            print (item);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
