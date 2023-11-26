using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceTrigger : MonoBehaviour
{
    public Collider2D player;


    public GameObject Dialogue;

    public GameObject Fruit;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Dialogue.SetActive(true);
            PlayerMovement.instance.runSpeed = 0;
            }

        }
    }
