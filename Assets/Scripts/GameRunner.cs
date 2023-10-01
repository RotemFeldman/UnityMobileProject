using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameRunner : MonoBehaviour
{
    public static GameRunner instance;

    [SerializeField] GameObject Player1Scene;
    [SerializeField] GameObject Player2Scene;

    [SerializeField] GameObject P1ChoiceSpace;
    [SerializeField] GameObject P2ChoiceSpace;

    [SerializeField] GameObject WinnerPannel;
    [SerializeField] TextMeshProUGUI WinnerText;

    private GameObject ActivePlayerScene;

    private string _P1Choice = "";
    private string _P2Choice = "";

    private string RoundWinner = "";

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Start()
    {
        ActivePlayerScene = Player1Scene;
    }

    public void NextTurn()
    {
        if (ActivePlayerScene == Player1Scene) 
        {
            P1ChoiceSpace.GetComponentInChildren<DragAndDrop>().ReturnToOriginalParent();
            Player1Scene.SetActive(false);
            Player2Scene.SetActive(true);
            ActivePlayerScene = Player2Scene;
        } 
        else
        {
            P2ChoiceSpace.GetComponentInChildren<DragAndDrop>().ReturnToOriginalParent();
            Player2Scene.SetActive(false);
            Player1Scene.SetActive(true);
            ActivePlayerScene = Player1Scene;

            CalculateScores();
            WinnerPannel.SetActive(true);
            if (RoundWinner != "Draw")
                WinnerText.text = $"{RoundWinner} WON!";
            else
                WinnerText.text = "ITS A DRAW!";
        }
    }

    void CalculateScores()
    {
        if (_P1Choice == "Rock")
        {
            if (_P2Choice == "Paper")
            {
                RoundWinner = "Red Player";
            }
            else if (_P2Choice == "Scissors")
            {
                RoundWinner = "Blue Player";
            }
            else
            {
                RoundWinner = "Draw";
            }
        }
        else if (_P1Choice == "Paper")
        {
            if (_P2Choice == "Scissors")
            {
                RoundWinner = "Red Player";
            }
            else if (_P2Choice == "Rock")
            {
                RoundWinner = "Blue Player";
            }
            else
            {
                RoundWinner = "Draw";
            }
        }
        else if (_P1Choice == "Scissors")
        {
            if (_P2Choice == "Rock")
            {
                RoundWinner = "Red Player";
            }
            else if (_P2Choice == "Paper")
            {
                RoundWinner = "Blue Player";
            }
            else
            {
                RoundWinner = "Draw";
            }
        }

        //Debug.Log(RoundWinner);
    }

    public void PlayerChoice(int plrNum, string choiceName)
    {
        if (plrNum == 1)
        {
            _P1Choice = choiceName;
        }
        else if (plrNum == 2)
        {
            _P2Choice = choiceName;
        }
    }

    public void Continue()
    {
        WinnerPannel.SetActive(false);
    }
}
