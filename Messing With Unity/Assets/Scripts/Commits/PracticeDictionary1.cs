using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDictionary1 : MonoBehaviour{
    public Hashtable randomDetails = new Hashtable();

    // Start is called before the first frame update
    void Start(){
        randomDetails.Add("firstName", "colt");
        randomDetails.Add("lastName", "hedin");
        randomDetails.Add("gender", "male");
        randomDetails.Add("isMarried", true);
        randomDetails.Add("age", 27);

        Debug.Log((string)randomDetails["firstName"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
