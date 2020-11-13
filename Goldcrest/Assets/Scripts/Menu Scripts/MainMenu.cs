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

    public Text level0Score;
    public Text level1Score;
    public Text level2Score;
    public Text level3Score;
    public Text level4Score;
    public int level1Rating;
    public int level2Rating;
    public int level3Rating;
    public int level4Rating;

    public Image lvl0Star1;
    public Image lvl0Star2;
    public Image lvl0Star3;
    public Image lvl1Star1;
    public Image lvl1Star2;
    public Image lvl1Star3;
    public Image lvl2Star1;
    public Image lvl2Star2;
    public Image lvl2Star3;
    public Image lvl3Star1;
    public Image lvl3Star2;
    public Image lvl3Star3;
    public Image lvl4Star1;
    public Image lvl4Star2;
    public Image lvl4Star3;


    private void Awake()
    {
        Application.targetFrameRate = 60; // Sets frame rate to 60  when program launches
    }
    private void Start()
    {
        Time.timeScale = 1f;

        GameManager.Instance.isMoving = false;

        lvl0Star1.enabled = false;
        lvl0Star2.enabled = false;
        lvl0Star3.enabled = false;

        lvl1Star1.enabled = false; // Sets level 1 stars blank
        lvl1Star2.enabled = false;
        lvl1Star3.enabled = false;

        lvl2Star1.enabled = false;
        lvl2Star2.enabled = false;
        lvl2Star3.enabled = false;

        lvl3Star1.enabled = false;
        lvl3Star2.enabled = false;
        lvl3Star3.enabled = false;

        lvl4Star1.enabled = false;
        lvl4Star2.enabled = false;
        lvl4Star3.enabled = false;

        GameManager.Instance.inLevel1 = false;
        GameManager.Instance.inLevel2 = false;
        GameManager.Instance.inLevel3 = false;
        GameManager.Instance.inLevel4 = false;
        GameManager.Instance.inDemo = false;
    }

    public void startLevel0()
    {
        SceneManager.LoadScene("Scenes/Demo", LoadSceneMode.Single); // Load Demo level
    }
    public void startLevel1()
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
    public void startLevel3()
    {
        if (GameManager.Instance.lvl3Unlocked)
        {
            SceneManager.LoadScene("Scenes/Level-3", LoadSceneMode.Single);
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
        updateLevel2();
        updateLevel3();
        updateLevel4();
        updateDemo();
    }

    public void updateDemo()
    {
        level0Score.text = GameManager.Instance.level0Score.ToString(); // Displays high score on level menu
        GameManager.Instance.level0Rating();



        if (GameManager.Instance.lvl0Rating < 50f) // Displays star rating
        {
            return;
        }

        if (GameManager.Instance.lvl0Rating >= 50f)
        {
            lvl0Star1.enabled = true;

            if (GameManager.Instance.lvl0Rating >= 75f)
            {
                lvl0Star2.enabled = true;

                if (GameManager.Instance.lvl0Rating >= 100f)
                {
                    lvl0Star3.enabled = true;
                }
            }
        }
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

    public void updateLevel2()
    {
        level2Score.text = GameManager.Instance.level2Score.ToString(); // Displays high score on level menu
        GameManager.Instance.level2Rating();



        if (GameManager.Instance.lvl2Rating < 50f) // Displays star rating
        {
            return;
        }

        if (GameManager.Instance.lvl2Rating >= 50f)
        {
            lvl2Star1.enabled = true;

            if (GameManager.Instance.lvl2Rating >= 75f)
            {
                lvl2Star2.enabled = true;

                if (GameManager.Instance.lvl2Rating >= 100f)
                {
                    lvl2Star3.enabled = true;
                }
            }
        }
    }

    public void updateLevel3()
    {
        level3Score.text = GameManager.Instance.level3Score.ToString(); // Displays high score on level menu
        GameManager.Instance.level3Rating();



        if (GameManager.Instance.lvl3Rating < 50f) // Displays star rating
        {
            return;
        }

        if (GameManager.Instance.lvl3Rating >= 50f)
        {
            lvl3Star1.enabled = true;

            if (GameManager.Instance.lvl3Rating >= 75f)
            {
                lvl3Star2.enabled = true;

                if (GameManager.Instance.lvl3Rating >= 100f)
                {
                    lvl3Star3.enabled = true;
                }
            }
        }
    }

    public void updateLevel4()
    {
        level4Score.text = GameManager.Instance.level4Score.ToString(); // Displays high score on level menu
        GameManager.Instance.level4Rating();



        if (GameManager.Instance.lvl4Rating < 50f) // Displays star rating
        {
            return;
        }

        if (GameManager.Instance.lvl4Rating >= 50f)
        {
            lvl4Star1.enabled = true;

            if (GameManager.Instance.lvl4Rating >= 75f)
            {
                lvl4Star2.enabled = true;

                if (GameManager.Instance.lvl4Rating >= 100f)
                {
                    lvl4Star3.enabled = true;
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

    public void playClick()
    {
        FindObjectOfType<AudioManager>().Play("ButtonPress");
    }
}
