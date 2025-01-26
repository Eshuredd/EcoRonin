using UnityEngine;
using TMPro;

public class StartGamePanel : MonoBehaviour
{
    public GameObject startPanel;   // Panel that contains the message
    public TMP_Text startMessage;   // Text component for the message

    void Start()
    {
        // Show the start panel at the beginning
        startPanel.SetActive(true);

        // Set the start message
        startMessage.text = "Collect all the SDGs scattered to win the game! \n \n \n Press E to Exit the Game";

        // Call HideStartPanel after 5 seconds
        Invoke("HideStartPanel", 5f);
    }

    void HideStartPanel()
    {
        // Hide the start panel after 5 seconds
        startPanel.SetActive(false);

        // Optionally, unpause the game if it was paused
        Time.timeScale = 1;  // Ensure the game time is running
    }
}
