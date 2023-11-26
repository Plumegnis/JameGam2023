using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EventTriggering : MonoBehaviour
{
    public static EventTriggering instance;
    public int EventTriggerNumber = 0;
    public Collider2D Collider;
    public GameObject Life1;
    public GameObject Life2;
    public GameObject Life3;
    public GameObject Life4;
    public GameObject Life5;
    public GameObject Life6;



    private void Awake()
    {
        instance = this;
    }
    void Update()
    {

        switch (EventTriggerNumber)
        {
            case 0:
                break;
            case 1:
                Event1();
                break;
            case 3:
                Event2();
                break;
            case 5:
                Event3();
                break;
            case 7:
                Event4();
                break;
            case 9:
                Event5();
                break;
        }
    }

    private void Event1()
    {
        Life1.SetActive(true);
        EventTriggerNumber++;
    }

    private void Event2()
    {
        Life2.SetActive(true);
        EventTriggerNumber++;
    }
    private void Event3()
    {
        Life3.SetActive(true);
        EventTriggerNumber++;
    }
    private void Event4()
    {
        Life4.SetActive(true);
        EventTriggerNumber++;
    }
    private void Event5()
    {
        Life5.SetActive(true);
        EventTriggerNumber++;
    }
}

