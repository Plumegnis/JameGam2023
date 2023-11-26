using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatMovement : MonoBehaviour
{

    public GameObject lifeTalking;
    public GameObject intro;
    public string panelTag = "Panel";


    // Start is called before the first frame update
    void Start()
    {
        lifeTalking.SetActive(false);
        intro.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] panels = GameObject.FindGameObjectsWithTag(panelTag);
        // Check if a GameObject with the specified tag is enabled
        GameObject panel = GameObject.FindWithTag(panelTag);
        // Check if at least one panel is active

        if (panels.Length > 0)
        {

                if (Input.GetKeyDown(KeyCode.A))
                {
                    lifeTalking.SetActive(true);
                }

                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    lifeTalking.SetActive(true);
                }
        }
    }
}
