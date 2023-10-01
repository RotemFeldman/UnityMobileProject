using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public static int ThemeId;

    public GameObject ThemeSelectPanel;
    public GameObject MainMenuPanel;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

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

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
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
