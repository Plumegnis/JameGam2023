using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatedJars : MonoBehaviour
{
    public GameObject Jar0; // Przypisz obiekt, który ma się pojawić po naciśnięciu przycisku "Save"
    public Savebutton saveButton; // Przypisz obiekt skryptu Savebutton, który obsługuje zapis

    void Start()
    {
        if (saveButton == null)
        {
            Debug.LogError("Savebutton script not assigned!");
        }
    }

    void Update()
    {
        // Sprawdź, czy naciśnięto przycisk "Save" w skrypcie Savebutton
        if (saveButton != null && saveButton.IsSaveButtonPressed())
        {
            // Sprawdź, czy obiekt do pokazania został przypisany
            if (Jar0 != null)
            {
                // Aktywuj obiekt (pojawi się)
                Jar0.SetActive(true);

                // Optional: You can instantiate a new instance of the object if needed
                // Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
            }
            else
            {
                Debug.LogWarning("Object to spawn not assigned!");
            }
        }
   
        Debug.Log("Update is being called");
        if (saveButton != null && saveButton.IsSaveButtonPressed())
        {
            Debug.Log("Save button is pressed");
            if (Jar0 != null)
            {
                Debug.Log("Object to show is not null");
                Jar0.SetActive(true);
            }
            else
            {
                Debug.LogWarning("Object to show not assigned!");
            }
        }
    }
}