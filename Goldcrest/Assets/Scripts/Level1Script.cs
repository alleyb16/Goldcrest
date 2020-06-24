using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;


// To do :
// Add victory screen displaying gold earned, total gold, score earned, high score

public class Level1Script : MonoBehaviour
{

    //private int coins = 0;
   // private int score = 0;
    private float levelTimer = 300f;
    private int timeRemaining;

    private float parScore = 500f;
    private float completionPercent;

    private bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        // Resets level stats on beginning new level
        GameManager.Instance.coinsCollected = 0;
        GameManager.Instance.currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            levelTimer -= Time.deltaTime;
            timeRemaining = (int)(levelTimer);
        }
    }

    private void OnGUI() // Displays useful info
    {
        GUI.Label(new Rect(10, 40, 200, 20), "Time Remaining : " + timeRemaining);
        GUI.Label(new Rect(10, 20, 200, 20), "Gold Collected: " + GameManager.Instance.coinsCollected);
        GUI.Label(new Rect(10, 50, 200, 20), "Score : " + GameManager.Instance.currentScore);
        GUI.Label(new Rect(10, 60, 200, 20), "High Score : " + GameManager.Instance.level1Score);
        GUI.Label(new Rect(10, 70, 200, 20), "Percent Complete : " + completionPercent);
    }

    private void OnTriggerEnter(Collider other) //When player collides with the level trigger box...
    {
        if (other.tag == "Player")
        {
            if(GameManager.Instance.coinsCollected > 20) // If player meets completion requirements...
            {
                print("Level complete!");
                GameManager.Instance.depositCoins(); // Store collected coins
                GameManager.Instance.currentScore += timeRemaining; // Add time remaining to score
                if (GameManager.Instance.currentScore > GameManager.Instance.level1Score)
                {
                    GameManager.Instance.level1Score = GameManager.Instance.currentScore; // Store score for level and keep highest score
                }
                print(GameManager.Instance.level1Score);
                gameOver = true; // Disable the timer
                percentComplete(); //Determine percentage complete w/ par score
            }
        }
    }

    private void percentComplete()
    {
        completionPercent = GameManager.Instance.currentScore / parScore * 100;
        print(completionPercent);
        GameManager.Instance.currentScore = 0;
    }
}
