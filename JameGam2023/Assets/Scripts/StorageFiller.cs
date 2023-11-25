using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Runtime.ExceptionServices;
using System;
using UnityEngine.EventSystems;

public class StorageFiller : MonoBehaviour
{
    public Image fillImage;

    public float fillSpeed = 1000f; // Speed at which the image fills (0 to 1 per second)

    public GameObject BSOD;

    public float randomeventchance;

    private bool isPaused = false;

    public int EventTriggerNumber = 0;
    public bool isfilling = true;
    public float currentFillAmount;
    public Image jarOfJam;


    private void Start()
    {
        isPaused = false;
    }

    private void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0.0f; // Pause the game
        }
        else
        {
            Time.timeScale = 1.0f; // Resume normal time
        }
    }




    // Optional: Add your singleton-specific code here


    void Update()
    {
        currentFillAmount -= Time.deltaTime / fillSpeed;
        currentFillAmount = Mathf.Clamp01(currentFillAmount);
        fillImage.fillAmount = currentFillAmount;

        if (currentFillAmount == 0)
        {
            BSOD.SetActive(true);
            TogglePause();
        }

        
    }
}