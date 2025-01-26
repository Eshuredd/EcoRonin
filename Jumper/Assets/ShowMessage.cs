using UnityEngine;
using TMPro;

public class SDGDiscovery : MonoBehaviour
{
    public GameObject messagePanel;  // Assign in Inspector - the panel to show the message
    public TMP_Text messageText;      // Assign in Inspector - TextMeshPro component for displaying SDG message
    public string sdgMessage;         // Customize this message for each SDG

    private bool isDiscovered = false;  // To prevent multiple scoring

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player enters the trigger and hasn't discovered the SDG yet
        if (other.CompareTag("Player"))
        {
            // Always show the message panel
            if (messagePanel != null && messageText != null)
            {
                messageText.text = sdgMessage;  // Update text to display the SDG message
                messagePanel.SetActive(true);   // Show the panel
            }

            // Only add to score if this SDG hasn't been discovered yet
            if (!isDiscovered)
            {
                isDiscovered = true;  // Mark this SDG as discovered
                ScoreManager.instance.AddScore(gameObject);  // Pass the SDG object to the score manager
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            messagePanel.SetActive(false);  // Hide the panel when player leaves
            isDiscovered = false;  // Reset for next entry to allow panel to show again
        }
    }
}
