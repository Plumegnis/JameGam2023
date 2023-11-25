using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatMovement : MonoBehaviour
{

    public GameObject lifeTalking;

    // Start is called before the first frame update
    void Start()
    {
        lifeTalking.SetActive(false);
    }

    // Update is called once per frame
    void Update()
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
