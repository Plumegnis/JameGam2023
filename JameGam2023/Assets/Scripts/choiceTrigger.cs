using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceTrigger : MonoBehaviour
{
    public Collider2D Collider;
    public GameObject Dialogue;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Dialogue.SetActive(true);
        }
    }
    }
