using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDictionary3 : MonoBehaviour{
    public Hashtable somedetails = new Hashtable();

    // Start is called before the first frame update
    void Start(){
        somedetails.Add("firstName", "Justin");
        somedetails.Add("lastName", "Hedin");
        somedetails.Add("gender", "male");
        somedetails.Add("isMarried", true);
        somedetails.Add("age", 30);

        Debug.Log((string)somedetails["firstName"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
