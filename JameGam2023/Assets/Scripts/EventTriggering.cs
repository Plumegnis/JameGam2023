using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggering : MonoBehaviour
{
    public int EventTriggerNumber = 0;
    public Collider2D Collider;
    public GameObject Dialogue;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "movable")
        {
            EventTriggerNumber++;
            col.gameObject.SetActive(false);
        }


        switch (EventTriggerNumber)
        {
            case 0:
                break;
            case 3:
                Event1();
                break;
            case 10:
                Event2();
                break;
        }
    }

    private void Event1()
    {
    
    }

    private void Event2()
    {

    }
}

