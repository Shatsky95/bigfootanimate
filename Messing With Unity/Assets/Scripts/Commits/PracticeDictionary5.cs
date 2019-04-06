using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDictionary5 : MonoBehaviour{
    public Hashtable subtledetails = new Hashtable();
    // Start is called before the first frame update
    void Start(){
        subtledetails.Add("firstName", "sherri");
        subtledetails.Add("lastName", "Hedin");
        subtledetails.Add("gender", "female");
        subtledetails.Add("isMarried", true);
        subtledetails.Add("age", 54);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
