using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Variables : MonoBehaviour
// variables 
{public int number;
public float speed; 
public string name;
/*this
is
a
 multiline
 comment
  */
    // Start is called before the first frame update
    void Start()
    { number = 10;
    speed  = 0.94f;
    name = "bob"; 

        
    }

    // Update is called once per frame
    void Update()
    {
      transform.position = new Vector3(number,0,0);
        
    }
}
