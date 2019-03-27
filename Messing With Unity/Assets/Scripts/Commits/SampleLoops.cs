using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleLoops : MonoBehaviour {

    public int candybars = 100;
    // Start is called before the first frame update
    void Start(){
        for(int i = 0; i < candybars; i++){
            print(i +"candy bars are in my mouth");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
