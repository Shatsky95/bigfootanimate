using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPractice1 : MonoBehaviour{
    public int jellybeans = 100;
    // Start is called before the first frame update
    void Start(){
        for(int i = 0; i < jellybeans; i++){
            print(i +"are all the jellybeans in the world");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
