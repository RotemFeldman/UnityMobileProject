using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject MenuButton;
    public static bool IsPaused { get; private set; }
    public void SetPause(bool isEnable)
    { 
        IsPaused = isEnable;

        if (pauseMenu.activeSelf)
        {
            pauseMenu.SetActive(false);
            MenuButton.SetActive(true);
        }
        else
        {
            pauseMenu.SetActive(true);
            MenuButton.SetActive(false);
        }
            
    }
}
