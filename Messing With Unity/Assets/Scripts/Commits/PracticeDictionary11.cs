using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDictionary11 : MonoBehaviour
{ public Hashtable tyanainfo = new Hashtable();
    // Start is called before the first frame update
    void Start()
    {   tyanainfo.Add("firstName", "Tyana");
        tyanainfo.Add("lastName", "Hedin");
        tyanainfo.Add("Gender", "Female");
        tyanainfo.Add("isMarried", false);
        tyanainfo.Add("age", 16);

        Debug.Log((string)tyanainfo["lastName"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
