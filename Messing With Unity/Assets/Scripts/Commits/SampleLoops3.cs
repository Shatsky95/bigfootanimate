using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleLoops3 : MonoBehaviour{
    public int shoes = 100;

    // Start is called before the first frame update
    void Start(){
        for(int i = 0; i < shoes; i++){
            print(i +"too many shoes in the closet");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
