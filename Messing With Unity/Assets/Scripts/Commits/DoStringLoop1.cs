using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoStringLoop1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        bool donotenter = false;
        do{
            print("DANGER");
        }while(donotenter == true);

        string[] dogs = new string[3];
        dogs[0] = "first dog";
        dogs[1] = "second dog";
        dogs[2] = "third dog";

        foreach(string animal in dogs){
            print(animal);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
