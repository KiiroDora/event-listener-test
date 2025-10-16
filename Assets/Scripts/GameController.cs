using UnityEngine;

public class GameController : MonoBehaviour
{
    public int score { get; private set; }  // can get it outside of the script, but can only set inside of it

    void Start()
    {
        score = 0;
    }
    public void IncreaseScore()
    {
        score++;
    }
}
