using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject MainPage;
    public GameObject Options;

    public void StartGamePressed()
    {
        SceneManager.LoadScene("02");
    }

    public void QuitGameButtonPressed()
    {
        Application.Quit();
    }

    public void OptionPageShow()
    {
        MainPage.SetActive(false);
        Options.SetActive(true);
    }

    public void MainPageShow()
    {
        MainPage.SetActive(true);
        Options.SetActive(false);
    }
}
