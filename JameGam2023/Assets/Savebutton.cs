using UnityEngine;
using System.Collections;

public class Savebutton : MonoBehaviour
{
    public GameObject cardObject; // Przypisz obiekt karty do tego pola w inspektorze Unity
    public bool hideButtonWithCard = false; // Decyduje, czy przycisk ma zniknąć razem z kartą
    public bool hideAllButtons = true; // Decyduje, czy wszystkie przyciski mają zniknąć jednocześnie

    private int savedCardsCount = 0;

    void Start()
    {
        // Pobierz wcześniejszą ilość ocalonych kart z PlayerPrefs
        savedCardsCount = PlayerPrefs.GetInt("SavedCards", 0);
    }

    public void OnSaveButtonPressed()
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

            // Zwiększ liczbę ocalonych kart
            savedCardsCount++;

            // Zapisz nową ilość ocalonych kart w PlayerPrefs
            PlayerPrefs.SetInt("SavedCards", savedCardsCount);

            // Wymuszenie zapisu danych do PlayerPrefs
            PlayerPrefs.Save();
        }
    }
}