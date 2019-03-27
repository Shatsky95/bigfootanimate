using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleLoops5 : MonoBehaviour{
    public int books = 100;

    // Start is called before the first frame update
    void Start(){
        for(int i = 0; i < books; i++){
            print(i +"too many books on the shelves");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
