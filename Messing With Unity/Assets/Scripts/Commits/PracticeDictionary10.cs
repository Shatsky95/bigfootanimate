using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDictionary10 : MonoBehaviour{
    public Hashtable rexinfo = new Hashtable();
    // Start is called before the first frame update
    void Start(){
        rexinfo.Add("name", "rex");
        rexinfo.Add("breed", "lab");
        rexinfo.Add("superHyper", true);
        rexinfo.Add("age", 5);

         Debug.Log((string)rexinfo["name"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
