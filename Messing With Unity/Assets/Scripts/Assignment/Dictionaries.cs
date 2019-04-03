using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour{
    public Hashtable personalDetails = new Hashtable();

    // Start is called before the first frame update
    void Start(){
        personalDetails.Add("firstName", "Greg");
        personalDetails.Add("lastName", "Lukosek");
        personalDetails.Add("gender", "male");
        personalDetails.Add("isMarried", true);
        personalDetails.Add("age", 29);

        Debug.Log((string)personalDetails["firstName"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
