using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDictionary7 : MonoBehaviour{
    public Hashtable normalinfo = new Hashtable();
    // Start is called before the first frame update
    void Start(){
        normalinfo.Add("firstName", "Taylor");
        normalinfo.Add("lastName", "Hedin");
        normalinfo.Add("gender", "female");
        normalinfo.Add("isMarried", true);
        normalinfo.Add("age", 23);

         Debug.Log((string)normalinfo["lastName"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
