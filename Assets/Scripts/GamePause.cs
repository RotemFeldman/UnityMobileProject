using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public static bool IsPaused { get; private set; }
    public void SetPause(bool isEnable)
    {
        IsPaused = isEnable;

        if (pauseMenu.active)
            pauseMenu.SetActive(false);
        else
            pauseMenu.SetActive(true);
    }
}
