
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelShow : MonoBehaviour
{
    public AudioSource collectSound;
    public GameObject panel; // Assign the panel from the Unity Inspector

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play(); // Play collection sound
        ScoringSystem.theScore++; // Increase score

        if (panel != null)
        {
            panel.SetActive(true); // Show the panel
        }

        Destroy(gameObject); // Destroy the collected object
    }
}
