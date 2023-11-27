using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lolbug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Running()
    {
       PlayerMovement.instance.runSpeed = 30;
   
           
    }
}
