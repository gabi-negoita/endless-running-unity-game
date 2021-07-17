using UnityEngine;
using UnityEngine.SceneManagement;


public class ChooseLevel : MonoBehaviour
{
    public void LoadDesertLevel()
    {
        SceneManager.LoadScene("DesertLevel");
    }

    public void LoadChristmasLevel()
    {
        SceneManager.LoadScene("ChristmasLevel");
    }

}
