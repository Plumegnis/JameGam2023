using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Savebutton : MonoBehaviour
{
    public GameObject cardObject; // Przypisz obiekt karty do tego pola w inspektorze Unity
    public bool hideButtonWithCard = false; // Decyduje, czy przycisk ma zniknąć razem z kartą
    public bool hideAllButtons = false; // Decyduje, czy wszystkie przyciski mają zniknąć jednocześnie
    public bool giveToLifeButtonPressed = false; // Informuje, czy przycisk "Give to Life" został naciśnięty

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
            // Sprawdź, czy przycisk ma zniknąć razem z kartą, wszystkie przyciski mają zniknąć, 
            // lub został naciśnięty przycisk "Give to Life"
            if (hideButtonWithCard || hideAllButtons || giveToLifeButtonPressed)
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

        // Sprawdź, czy wszystkie przyciski mają zniknąć
        if (hideAllButtons || giveToLifeButtonPressed)
        {
            // Znajdź wszystkie przyciski w scenie
            Button[] allButtons = FindObjectsOfType<Button>();

            // Zniknij wszystkie przyciski
            foreach (Button button in allButtons)
            {
                button.gameObject.SetActive(false);
            }
        }
    }
}