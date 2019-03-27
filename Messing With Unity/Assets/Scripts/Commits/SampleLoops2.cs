using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleLoops2 : MonoBehaviour {
    public int hats = 100;

    // Start is called before the first frame update
    void Start(){
        for(int i = 0; i < hats; i++){
            print(i +"too many hats on the wall");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
