using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelShow : MonoBehaviour
{
    public string panelTag = "Panel";
    public GameObject card;

    void Update()
    {
        GameObject panel = GameObject.FindWithTag(panelTag);
        // Check if at least one panel is active
        if (card.activeInHierarchy)
        {
            panel.SetActive(false);
        }
    }
}
