using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject winScreen;

    GameController gameController;

    public int coinsNeededToWin = 8;

    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + gameController.score;
    }

    public void CheckWin()
    {
        if (gameController.score == coinsNeededToWin)
        {
            winScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
