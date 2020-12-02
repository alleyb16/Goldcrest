using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Inventory inventory;

    public Text goldCount;
    public Text starCount;
    public Text levelsComplete;
    public Text offensiveCardsCollected;
    public Text defensiveCardsCollected;
    public Text consumableCardsCollected;

    public Text level1Score;
    public int level1Rating;

    public Image lvl1Star1;
    public Image lvl1Star2;
    public Image lvl1Star3;


    private void Awake()
    {
        Application.targetFrameRate = 60; // Sets frame rate to 60  when program launches
    }
    private void Start()
    {
        Time.timeScale = 1f;

        GameManager.Instance.isMoving = false;

        lvl1Star1.enabled = false; // Sets level 1 stars blank
        lvl1Star2.enabled = false;
        lvl1Star3.enabled = false;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/Level-1", LoadSceneMode.Single); // Load first level
    }
    public void startLevel2()
    {
        if (GameManager.Instance.lvl2Unlocked)
        {
            SceneManager.LoadScene("Scenes/Level-2", LoadSceneMode.Single); // Load second level
        }
    }

    public void QuitGame() // Exit the application
    {
        print("Quit");
        Application.Quit();
    }

    void Update()
    {
        updateInventory();
        updateLevel1();
    }

    public void updateLevel1()
    {
        level1Score.text = GameManager.Instance.level1Score.ToString(); // Displays high score on level menu
        GameManager.Instance.level1Rating();



        if (GameManager.Instance.lvl1Rating < 50f) // Displays star rating
        {
            return;
        }

        if (GameManager.Instance.lvl1Rating >= 50f)
        {
            lvl1Star1.enabled = true;

            if (GameManager.Instance.lvl1Rating >= 75f)
            {
                lvl1Star2.enabled = true;

                if (GameManager.Instance.lvl1Rating >= 100f)
                {
                    lvl1Star3.enabled = true;
                }
            }
        }
    }

    public void updateInventory()
    {
        goldCount.text = GameManager.Instance.totalCoins.ToString(); // Updates the UI for total coins collected
        starCount.text = (GameManager.Instance.lvl1Stars + GameManager.Instance.lvl2Stars + GameManager.Instance.lvl3Stars + GameManager.Instance.lvl4Stars + " / 12").ToString(); // Updates UI for total stars collected
        levelsComplete.text = (GameManager.Instance.levelsCompleted + " / 4").ToString(); // Updates total levels completed

        offensiveCardsCollected.text = (inventory.totalOffensiveCards + " / 9").ToString();
        defensiveCardsCollected.text = (inventory.totalDefensiveCards + " / 9").ToString();
        consumableCardsCollected.text = (inventory.totalConsumableCards + " / 3").ToString();
    }

    public void SaveGame()
    {
        GameManager.Instance.SaveGame();
    }
    public void LoadGame()
    {
        GameManager.Instance.LoadGame();
    }
}
