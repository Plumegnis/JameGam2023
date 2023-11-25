using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggering : MonoBehaviour
{
    public int EventTriggerNumber = 0;
    public Collider2D Collider;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            EventTriggerNumber++;
        }


        switch (EventTriggerNumber)
        {
            case 0:
                break;
            case 1:
                Event1();
                break;
            case 2:
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
    public void StartFillup()
    {

    }
}

