using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    public int maxScore = 17;
    private HashSet<GameObject> discoveredSDGs = new HashSet<GameObject>();

    public GameObject gameOverPanel; // Assign this in the Unity Inspector
    public TMP_Text gameOverText;    // Assign the TextMeshPro UI element in Inspector

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(GameObject sdgObject)
    {
        if (!discoveredSDGs.Contains(sdgObject))
        {
            discoveredSDGs.Add(sdgObject);
            score++;
            Debug.Log("Score: " + score);

            if (score >= maxScore)
            {
                StartCoroutine(EndGameWithDelay());
            }
        }
    }

    // Coroutine to delay before showing the game over panel
    private IEnumerator EndGameWithDelay()
    {
        Debug.Log("Congratulations! You have discovered all SDGs. Showing panel in 2 seconds...");

        yield return new WaitForSeconds(5);  // Wait for 5 seconds before showing the panel

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
            gameOverText.text = "Game Over! You have discovered all the SDGs. \n \n \n Press 'E' to return to main menu";
        }

        // Exit the game after another 5 seconds
        yield return new WaitForSeconds(2);
    }

 /*   private void QuitGame()
    {
        Debug.Log("Exiting game...");
        Application.Quit();  // Works in build mode, not in editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Exit play mode in Unity Editor
#endif
    }*/
}
