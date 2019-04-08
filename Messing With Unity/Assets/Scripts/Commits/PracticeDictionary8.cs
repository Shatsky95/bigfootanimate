using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDictionary8 : MonoBehaviour{
    public Hashtable tristaninfo = new Hashtable();
    // Start is called before the first frame update
    void Start(){
        tristaninfo.Add("firstName", "tristan");
        tristaninfo.Add("lastName", "smith");
        tristaninfo.Add("gender", "male");
        tristaninfo.Add("isMarried", false);
        tristaninfo.Add("age", 24);

         Debug.Log((string)tristaninfo["age"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
