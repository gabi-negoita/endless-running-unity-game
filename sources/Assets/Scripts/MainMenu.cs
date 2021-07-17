using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quitting...");
        Application.Quit();
    }
}
