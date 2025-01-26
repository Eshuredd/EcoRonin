using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Button Menu;

    // Update is called once per frame
    void Update()
    {
        if (Menu != null)
        {
            Menu.onClick.AddListener(() =>
            {
                SceneManager.LoadScene("Main Menu");
            });
        }
    }
}
