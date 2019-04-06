using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDictionary4 : MonoBehaviour{
    public Hashtable greatdetails = new Hashtable();
    // Start is called before the first frame update
    void Start(){
        greatdetails.Add("firstName", "Monty");
        greatdetails.Add("lastName", "Hedin");
        greatdetails.Add("gender", "male");
        greatdetails.Add("isMarried", true);
        greatdetails.Add("age", 61);
        
        Debug.Log((string)greatdetails["firstName"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
