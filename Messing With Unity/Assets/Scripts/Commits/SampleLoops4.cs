using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleLoops4 : MonoBehaviour{
    public int games = 100;

    // Start is called before the first frame update
    void Start(){
        for(int i = 0; i < games; i++){
            print(i +"too many games on the counter");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
