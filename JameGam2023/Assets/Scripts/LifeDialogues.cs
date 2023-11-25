using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeDialogues : MonoBehaviour
{
    public int EventTriggerNumber = 0;
    public Collider2D Collider;
    public GameObject Dialogue;
    void OnTriggerEnter2D(Collider2D col)
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
            case 10:
                Event2();
                break;
        }
    }

    private void Event1()
    {
        Dialogue.SetActive(true);
    }

    private void Event2()
    {

    }
}
