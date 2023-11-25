using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceTrigger : MonoBehaviour
{
    public Collider2D player;
    public GameObject Dialogue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Dialogue.SetActive(true);
        }
    }


    }
