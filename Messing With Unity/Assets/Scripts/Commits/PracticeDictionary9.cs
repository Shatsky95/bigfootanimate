using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDictionary9 : MonoBehaviour{
    public Hashtable copperinfo = new Hashtable();
    // Start is called before the first frame update
    void Start(){
        copperinfo.Add("name", "copper");
        copperinfo.Add("breed", "kelpie");
        copperinfo.Add("totalDork", true);
        copperinfo.Add("age", 1);

         Debug.Log((string)copperinfo["breed"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
