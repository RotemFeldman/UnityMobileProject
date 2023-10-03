using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public static int ThemeId;

    public GameObject ThemeSelectPanel;
    public GameObject MainMenuPanel;


    [Header("Player1 Options")]
    [SerializeField] private GameObject _rock;
    [SerializeField] private GameObject _paper;
    [SerializeField] private GameObject _scissors;

    [Header("Player2 Options")]
    [SerializeField] private GameObject _rock2;
    [SerializeField] private GameObject _paper2;
    [SerializeField] private GameObject _scissors2;

    private Sprite newImage;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Game")
        {
            switch (ThemeId)
            {
                case 1:
                    Debug.Log("Theme1");
                    newImage = Resources.Load<Sprite>("Sprites/RockBlue");
                    _rock.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/RockRed");
                    _rock2.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/PaperBlue");
                    _paper.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/PaperRed");
                    _paper2.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/ScissorsBlue");
                    _scissors.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/ScissorsRed");
                    _scissors2.GetComponent<Image>().overrideSprite = newImage;
                    break;
                case 2:
                    Debug.Log("Theme3");
                    newImage = Resources.Load<Sprite>("Sprites/NukeBlue");
                    _rock.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/NukeRed");
                    _rock2.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/RoachBlue");
                    _paper.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/RoachRed");
                    _paper2.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/FlipBlue");
                    _scissors.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/FlipRed");
                    _scissors2.GetComponent<Image>().overrideSprite = newImage;
                    break;
                case 3:
                    Debug.Log("Theme2");
                    newImage = Resources.Load<Sprite>("Sprites/KnightBlue");
                    _rock.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/KnightRed");
                    _rock2.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/PrincessBlue");
                    _paper.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/PrincessRed");
                    _paper2.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/DragonBlue");
                    _scissors.GetComponent<Image>().overrideSprite = newImage;

                    newImage = Resources.Load<Sprite>("Sprites/DragonRed");
                    _scissors2.GetComponent<Image>().overrideSprite = newImage;
                    break;
                default:
                    break;
            }
        }
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
        SceneManager.LoadScene("Game");
    }

    public void Credits()
    {
        SceneManager.LoadScene(2);
    }

}
