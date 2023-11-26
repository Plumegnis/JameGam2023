using FMOD;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
            }

        }

    public string panelTag = "Panel";

    void Update()
    {
        GameObject[] panels = GameObject.FindGameObjectsWithTag(panelTag);
        // Check if a GameObject with the specified tag is enabled
        GameObject panel = GameObject.FindWithTag(panelTag);
        // Check if at least one panel is active
        if (panels.Length > 0)
        {
            // Disable player movement when the panel is enabled
            PlayerMovement.instance.runSpeed = 0;
        }
        else
        {
            // Enable player movement when the panel is not enabled
            PlayerMovement.instance.runSpeed = 40f;
        }
    }
}
