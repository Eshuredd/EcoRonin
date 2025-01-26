using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button JunkJump;
    [SerializeField] private Button TrashDash;
    [SerializeField] private Button SDG_Explorer;
    [SerializeField] private Button VaccineRider;
    [SerializeField] private Button Quit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (JunkJump != null)
        {
            JunkJump.onClick.AddListener(() =>
            {
                SceneManager.LoadScene("Gameplay");
            });
        }
        if (TrashDash != null)
        {
            TrashDash.onClick.AddListener(() =>
            {
                SceneManager.LoadScene("Main");
            });
        }
        if (SDG_Explorer != null)
        {
            SDG_Explorer.onClick.AddListener(() =>
            {
                SceneManager.LoadScene("DemoScene");
            });
        }
        if (VaccineRider != null)
        {
            VaccineRider.onClick.AddListener(() =>
            {
                SceneManager.LoadScene("infiniHealth");
            });
        }
        if (Quit != null)
        {
            Quit.onClick.AddListener(() =>
            {
                Application.Quit();
            });
        }
    }
}
