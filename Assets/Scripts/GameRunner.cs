using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRunner : MonoBehaviour
{

    public static GameRunner instance;

    [SerializeField] GameObject Player1Scene;
    [SerializeField] GameObject Player2Scene;

    [SerializeField] GameObject P1ChoiceSpace;
    [SerializeField] GameObject P2ChoiceSpace;


    private GameObject ActivePlayerScene;

    private string _P1Choice = "";
    private string _P2Choice = "";

    private int _P1Score;
    private int _P2Score;

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
        _P1Choice = P1ChoiceSpace.transform.GetChild(0).tag;




        if (ActivePlayerScene == Player1Scene) 
        {
            Player1Scene.SetActive(false);
            Player2Scene.SetActive(true);
            ActivePlayerScene = Player2Scene;
        } 
        else
        {
            Player2Scene.SetActive(false);
            Player1Scene.SetActive(true);
            ActivePlayerScene = Player1Scene;
        }


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

}
