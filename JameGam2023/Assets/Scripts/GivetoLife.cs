using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GivetoLife : MonoBehaviour
{
    public GameObject cardObject; // Przypisz obiekt karty do tego pola w inspektorze Unity
    public bool hideButtonWithCard = false; // Decyduje, czy przycisk ma zniknąć razem z kartą
    public bool hideAllButtons = true; // Decyduje, czy wszystkie przyciski mają zniknąć jednocześnie

    private int savedCardsCount = 0;
    public GameObject preserveButton;
    public GameObject saveButton;

    public Button preserve;
    public Button save;

    void Start()
    {
        // Pobierz wcześniejszą ilość ocalonych kart z PlayerPrefs
        savedCardsCount = PlayerPrefs.GetInt("SavedCards", 0);
    }

    public void OnGiveButtonPressed()
    {
        // Sprawdź, czy obiekt karty istnieje
        if (cardObject != null)
        {
            StartCoroutine(HideButtonAndCardWithDelay());

        }

        preserve.interactable = false;
        save.interactable = false;

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
            EventTriggering.instance.EventTriggerNumber++;

            // Zapisz nową ilość ocalonych kart w PlayerPrefs
            PlayerPrefs.SetInt("SavedCards", savedCardsCount);

            // Wymuszenie zapisu danych do PlayerPrefs
            PlayerPrefs.Save();
        }

        // Znajdź wszystkie przyciski w scenie
        Button[] allButtons = FindObjectsOfType<Button>();

        // Sprawdź, czy wszystkie przyciski mają zniknąć
        if (hideAllButtons)
        {
            preserveButton.SetActive(false);
            saveButton.SetActive(false);

        }
    }
}
