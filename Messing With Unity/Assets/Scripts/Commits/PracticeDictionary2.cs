using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDictionary2 : MonoBehaviour{
    public Hashtable moredetails = new Hashtable();
    // Start is called before the first frame update
    void Start(){
        moredetails.Add("firstName", "Dylan");
        moredetails.Add("lastName", "Hedin");
        moredetails.Add("gender", "male");
        moredetails.Add("isMarried", false);
        moredetails.Add("age", 22);

        Debug.Log((string)moredetails["firstName"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
