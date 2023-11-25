using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Runtime.ExceptionServices;
using System;

public class StorageFiller : MonoBehaviour
{
    public Image fillImage;

    public float fillSpeed = 1000f; // Speed at which the image fills (0 to 1 per second)

    public GameObject BSOD;

    public float randomeventchance;

    public int EventTriggerNumber = 0;
    public bool isfilling = false;
    public float currentFillAmount;
    private static StorageFiller _instance;
    public GameObject DownloadProgramIcon;
    public GameObject windows;


    // Public property to access the singleton instance
    public static StorageFiller Instance
    {
        get
        {
            // If the instance does not exist, find or create it
            if (_instance == null)
            {
                _instance = FindObjectOfType<StorageFiller>();

                // If no instance is found in the scene, create a new GameObject with the singleton script
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject("MySingleton");
                    _instance = singletonObject.AddComponent<StorageFiller>();
                }
            }

            return _instance;
        }
    }

    // Optional: Add your singleton-specific code here

    private void Awake()
    {
        // Ensure there's only one instance of the singleton
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;

        }
    }

    void Update()
    {
        if (isfilling == true)
        {
            currentFillAmount += Time.deltaTime / fillSpeed;
            currentFillAmount = Mathf.Clamp01(currentFillAmount);
            fillImage.fillAmount = currentFillAmount;
        }

    }

}