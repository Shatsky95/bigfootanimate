using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_IF_Statements2 : MonoBehaviour {

    public string isPlaying;
    public bool socccerPlayer = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(isPlaying == "hurt"){
           if(socccerPlayer){
               print("I think I broke my leg");
           }
               

               else{
                   print("it hurts so bad");
               }
                   
               
       }            
        else if(isPlaying == "Motivated"){
            if(socccerPlayer){
                print("im gonna score that goal");
            }
        }


               
           
       

        

    }
}