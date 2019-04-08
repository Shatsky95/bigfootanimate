using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDictionary6 : MonoBehaviour{
    public Hashtable randominfo = new Hashtable();
    // Start is called before the first frame update
    void Start(){
        randominfo.Add("firstName", "texus");
        randominfo.Add("lastName", "Noe");
        randominfo.Add("gender", "male");
        randominfo.Add("ismarried", true);
        randominfo.Add("age", 26);

         Debug.Log((string)randominfo["firstName"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
