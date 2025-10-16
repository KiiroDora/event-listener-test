using UnityEngine;
using TMPro;
using System;

public class UIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject winScreen;
    [SerializeField] GameObject loseScreen;

    GameController gameController;

    public int coinsNeededToWin = 8;

    public static event Action OnPlayerWin;  // we declare an Action here, which are events solely *inside* the code

    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        OnPlayerWin += TriggerWin;
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + gameController.score;
    }

    public void CheckWin()
    {
        if (gameController.score == coinsNeededToWin)
        {
            OnPlayerWin?.Invoke();  // invoking our Action
        }
    }

    public void TriggerWin()
    {
        winScreen.SetActive(true);
    } 

    public void TriggerLose()
    {
        loseScreen.SetActive(true);
    }    
}
