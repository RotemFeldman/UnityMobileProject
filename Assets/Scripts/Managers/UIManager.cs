using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public GameObject ThemeSelectPanel;
    public GameObject MainMenuPanel;

    public void ThemeSelecter()
    {
        MainMenuPanel.SetActive(false);
        ThemeSelectPanel.SetActive(true);
    }

    public void MainMenu()
    {
        ThemeSelectPanel.SetActive(false);
        MainMenuPanel.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
