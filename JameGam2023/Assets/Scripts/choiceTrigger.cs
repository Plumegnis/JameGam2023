using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceTrigger : MonoBehaviour
{
    public Collider2D Collider;
    public GameObject Dialogue;
    void OnTriggernEnter2D(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Dialogue.SetActive(true);
        }
    }
    }
