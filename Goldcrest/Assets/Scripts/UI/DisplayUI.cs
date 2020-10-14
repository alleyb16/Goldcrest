using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI : MonoBehaviour
{
    public Level1Script LVL1;

    public Text goldText;
    public Text timerText;
    public Text scoreText;

    private float healthPercent;
    Image healthbar;

    // Start is called before the first frame update
    void Start()
    {
        healthbar = GameObject.Find("HealthBar").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        updateScores();
        updateHealth();
        print(GameManager.Instance.currentScore);
        print(GameManager.Instance.playerHealth);
    }

    void updateScores()
    {
        goldText.text = GameManager.Instance.coinsCollected.ToString();
        timerText.text = LVL1.timeRemaining.ToString();
        scoreText.text = GameManager.Instance.currentScore.ToString();
    }

    void updateHealth()
    {
        healthPercent = GameManager.Instance.playerHealth / GameManager.Instance.playerMaxHealth;
        healthbar.fillAmount = healthPercent;
        if(GameManager.Instance.playerHealth > GameManager.Instance.playerMaxHealth)
        {
            GameManager.Instance.playerHealth = GameManager.Instance.playerMaxHealth;
        }
    }
}
