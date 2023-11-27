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
    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {


            if (PlayerMovement.instance.runSpeed < 20)
            {
                PlayerMovement.instance.runSpeed = 30;
            }
        }
    }
}
