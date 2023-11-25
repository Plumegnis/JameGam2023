using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GivetoLife : MonoBehaviour
{
    public GameObject cardObject; // Przypisz obiekt karty do tego pola w inspektorze Unity
    public bool hideButtonWithCard = false; // Decyduje, czy przycisk ma zniknąć razem z kartą
    public bool hideAllButtons = false; // Decyduje, czy wszystkie przyciski mają zniknąć jednocześnie

    public void OnGivetoLifeButtonPressed()
    {
        // Sprawdź, czy obiekt karty istnieje
        if (cardObject != null)
        {
            StartCoroutine(HideButtonAndCardWithDelay());
        }
    }

    // Korutyna opóźniająca znikanie przycisku i karty
    IEnumerator HideButtonAndCardWithDelay()
    {
        // Poczekaj kilka sekund przed zniknięciem przycisku i karty
        yield return new WaitForSeconds(1.0f);

        // Sprawdź, czy obiekt przycisku istnieje (może zostać zniszczony podczas oczekiwania)
        if (gameObject != null)
        {
            // Sprawdź, czy przycisk ma zniknąć razem z kartą lub wszystkie przyciski mają zniknąć
            if (hideButtonWithCard || hideAllButtons)
            {
                // Zniknij przycisk
                gameObject.SetActive(false);
            }
        }

        // Sprawdź, czy obiekt karty istnieje (może zostać zniszczony podczas oczekiwania)
        if (cardObject != null)
        {
            // Zniknij obiekt karty
            cardObject.SetActive(false);
        }

        // Znajdź wszystkie przyciski w scenie
        Button[] allButtons = FindObjectsOfType<Button>();

        // Sprawdź, czy wszystkie przyciski mają zniknąć
        if (hideAllButtons)
        {
            // Zniknij wszystkie przyciski
            foreach (Button button in allButtons)
            {
                button.gameObject.SetActive(false);
            }
        }
    }
}