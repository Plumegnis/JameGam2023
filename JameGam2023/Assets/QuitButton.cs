using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Add a listener to the button click event
        GetComponent<Button>().onClick.AddListener(QuitGame);
    }

    // Method to quit the game (called when the button is clicked)
    public void QuitGame()
    {
        // This will only work in standalone builds (not in the Unity editor)
        // Application.Quit() doesn't work in the Unity editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}