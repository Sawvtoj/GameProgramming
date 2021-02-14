using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Slider slider;

    public void Awake()
    {
        slider = GameObject.GetComponent("Speed") as Slider;
    }

    public void OnEnable()
    {
        slider.onValueChanged.AddListener(delegate { sliderCallBack(slider); });
    }

    public void sliderCallBack(Slider slider)
    {
        PlayerController.speed = slider.value;
    }

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
