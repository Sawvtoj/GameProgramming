using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("LevelMenu");
    }

    public void Exit()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Setting()
    {
        SceneManager.LoadScene("Settings");
    }
}
