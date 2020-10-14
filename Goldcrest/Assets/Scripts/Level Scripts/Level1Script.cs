using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Level1Script : MonoBehaviour
{

    //private int coins = 0;
   // private int score = 0;
    private float levelTimer = 300f;
    public int timeRemaining;

    private float parScore = 500f;
    private float completionPercent;

    public bool gameOver = false;
    public bool levelEnd = false;

    public Text YourScoreValue;
    public Text GoldCollectedValue;
    public Text Rating;

    public Image star1;
    public Image star2;
    public Image star3;

    public Image cardUnlock;

    public Sprite ImgSwordT1;
    public Sprite ImgSwordT2;
    public Sprite ImgSwordT3;

    public Sprite ImgAxeT1;
    public Sprite ImgAxeT2;
    public Sprite ImgAxeT3;

    public Sprite ImgSpearT1;
    public Sprite ImgSpearT2;
    public Sprite ImgSpearT3;

    public Sprite ImgClothT1;
    public Sprite ImgClothT2;
    public Sprite ImgClothT3;

    public Sprite ImgLeatherT1;
    public Sprite ImgLeatherT2;
    public Sprite ImgLeatherT3;

    public Sprite ImgPlateT1;
    public Sprite ImgPlateT2;
    public Sprite ImgPlateT3;

    public Sprite ImgHealingT1;
    public Sprite ImgHealingT2;
    public Sprite ImgHealingT3;

    public GameObject summary;    // UI summary menu
    public GameObject levelFail; // UI failed menu

    public OutOfBounds bounds;

    // Start is called before the first frame update
    void Start()
    {
        // Resets level stats on beginning new level
        GameManager.Instance.coinsCollected = 0;
        GameManager.Instance.currentScore = 0;
        GameManager.Instance.playerHealth = GameManager.Instance.playerMaxHealth;

        star1.enabled = false;
        star2.enabled = false;
        star3.enabled = false;

        Time.timeScale = 1f;

        gameOver = false;
        levelEnd = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver && !levelEnd)
        {
            levelTimer -= Time.deltaTime;
            timeRemaining = (int)(levelTimer);
        }
        // Fails level if time runs out
        if (levelTimer < 0)
        {
            failLevel();
        }
        // Fails level if player dies
        if (GameManager.Instance.playerHealth <= 0)
        {
            failLevel();
        }
    }

    private void OnTriggerEnter(Collider other) //When player collides with the level trigger box...
    {
        if (other.tag == "Player")
        {
            if(GameManager.Instance.coinsCollected > 20) // If player meets completion requirements...
            {
                GameManager.Instance.currentScore += timeRemaining; // Add time remaining to score
                if (GameManager.Instance.currentScore > GameManager.Instance.level1Score)
                {
                    GameManager.Instance.level1Score = GameManager.Instance.currentScore; // Store score for level and keep highest score
                    
                    if (GameManager.Instance.level1Completed == false)
                    {
                        GameManager.Instance.levelsCompleted++;
                        GameManager.Instance.level1Completed = true;
                    }
                }
                percentComplete(); //Determine percentage complete w/ par score
                levelEnd = true; // Disable the timer
                summary.SetActive(true); // Set level over and display summary
                awardCard();
                GameManager.Instance.lvl2Unlocked = true;
                calculatePerformance(); // Calculates player performance and displays it to player
                Time.timeScale = 0f; //Slows speed to a pause
                GameManager.Instance.depositCoins(); // Store collected coins

            }
        }
    }

    // calculates the percentage for the level
    private void percentComplete()
    {
        completionPercent = GameManager.Instance.currentScore / parScore * 100;
    }

    // Calculates performance for summary menu
    public void calculatePerformance()
    {
        YourScoreValue.text = GameManager.Instance.currentScore.ToString();
        GoldCollectedValue.text = GameManager.Instance.coinsCollected.ToString();
        Rating.text = completionPercent.ToString() + "%";

        // if player rating < 50
        // Display all gray stars
        if (completionPercent < 50)
        {
            return;
        }
        // if player rating >= 50
        // Set star 1 yellow and stars 2 & 3 gray
        if (completionPercent >= 50)
        {
            star1.enabled = true;
            if (GameManager.Instance.lvl1Stars < 1)
            {
                GameManager.Instance.lvl1Stars = 1;
            }
        }
        // If player rating >= 75
        // display 2 yellow
        if (completionPercent >= 75)
        {
            star2.enabled = true;
            if (GameManager.Instance.lvl1Stars < 2)
            {

                GameManager.Instance.lvl1Stars = 2;
            }
        }
        // if player rating >= 100
        // display all yellow
        if (completionPercent >= 100)
        {
            star3.enabled = true;
            if (GameManager.Instance.lvl1Stars < 3)
            {
                GameManager.Instance.lvl1Stars = 3;
            }
        }
    }
    // Returns to main menu
    public void returnToMenu()
    {
        SceneManager.LoadScene("Scenes/Menu", LoadSceneMode.Single);
    }

    public void restartLevel()
    {
        SceneManager.LoadScene("Scenes/Demo", LoadSceneMode.Single);
    }

    public void failLevel()
    {
        gameOver = true;
        Time.timeScale = 0f;
        levelFail.SetActive(true);
    }

    public void awardCard() // Randomly picks a card to add to the player's inventory
    {
        if (completionPercent < 100) // if player gets less than 3 stars, select from tier 1 cards to award
        {
            var randomNum = Random.Range(1, 7);
            if (randomNum == 1)
            {
                if (!GameManager.Instance.hasSwordT1) // Award the player a Tier 1 Sword
                {
                    GameManager.Instance.hasSwordT1 = true;
                    GameManager.Instance.numSwordT1++;
                    print("You got a Tier 1 Sword! You now have a total of " + GameManager.Instance.numSwordT1);
                    cardUnlock.GetComponent<Image>().sprite = ImgSwordT1;
                    GameManager.Instance.offensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numSwordT1++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgSwordT1;
                }
            }
            if (randomNum == 2)
            {
                if (!GameManager.Instance.hasAxeT1) // Award the player a Tier 1 Axe
                {
                    GameManager.Instance.hasAxeT1 = true;
                    GameManager.Instance.numAxeT1++;
                    print("You got a Tier 1 Axe! You now have a total of " + GameManager.Instance.numAxeT1);
                    cardUnlock.GetComponent<Image>().sprite = ImgAxeT1;
                    GameManager.Instance.offensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numAxeT1++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgAxeT1;
                }
            }
            if (randomNum == 3)
            {
                if (!GameManager.Instance.hasSpearT1) // Award the player a Tier 1 Spear
                {
                    GameManager.Instance.hasSpearT1 = true;
                    GameManager.Instance.numSpearT1++;
                    print("You got a Tier 1 Spear! You now have a total of " + GameManager.Instance.numSpearT1);
                    cardUnlock.GetComponent<Image>().sprite = ImgSpearT1;
                    GameManager.Instance.offensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numSpearT1++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgSpearT1;
                }
            }
            if (randomNum == 4)
            {
                if (!GameManager.Instance.hasClothT1) // Award the player a Tier 1 Cloth
                {
                    GameManager.Instance.hasClothT1 = true;
                    GameManager.Instance.numClothT1++;
                    print("You got a Tier 1 Cloth! You now have a total of " + GameManager.Instance.numClothT1);
                    cardUnlock.GetComponent<Image>().sprite = ImgClothT1;
                    GameManager.Instance.defensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numClothT1++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgClothT1;
                }
            }
            if (randomNum == 5)
            {
                if (!GameManager.Instance.hasLeatherT1) // Award the player a Tier 1 Leather
                {
                    GameManager.Instance.hasLeatherT1 = true;
                    GameManager.Instance.numLeatherT1++;
                    print("You got a Tier 1 Leather! You now have a total of " + GameManager.Instance.numLeatherT1);
                    cardUnlock.GetComponent<Image>().sprite = ImgLeatherT1;
                    GameManager.Instance.defensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numLeatherT1++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgLeatherT1;
                }
            }
            if (randomNum == 6)
            {
                if (!GameManager.Instance.hasPlateT1) // Award the player a Tier 1 Plate
                {
                    GameManager.Instance.hasPlateT1 = true;
                    GameManager.Instance.numPlateT1++;
                    print("You got a Tier 1 Plate! You now have a total of " + GameManager.Instance.numPlateT1);
                    cardUnlock.GetComponent<Image>().sprite = ImgPlateT1;
                    GameManager.Instance.defensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numPlateT1++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgPlateT1;
                }
            }
            if (randomNum == 7)
            {
                if (!GameManager.Instance.hasHealingT1)
                {
                    GameManager.Instance.hasHealingT1 = true;
                    GameManager.Instance.numHealingT1++;
                    cardUnlock.GetComponent<Image>().sprite = ImgHealingT1;
                    GameManager.Instance.consumableCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numHealingT1++;
                    cardUnlock.GetComponent<Image>().sprite = ImgHealingT1;
                }
            }
        }
        if (completionPercent >= 100) // if player gets 3 stars, select from tier 1 and 2 cards to award
        {
            var randomNum = Random.Range(1, 14);
            if (randomNum == 1)
            {
                if (!GameManager.Instance.hasSwordT1) // Award the player a Tier 1 Sword
                {
                    GameManager.Instance.hasSwordT1 = true;
                    GameManager.Instance.numSwordT1++;
                    print("You got a Tier 1 Sword! You now have a total of " + GameManager.Instance.numSwordT1);
                    cardUnlock.GetComponent<Image>().sprite = ImgSwordT1;
                    GameManager.Instance.offensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numSwordT1++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgSwordT1;
                }
            }
            if (randomNum == 2)
            {
                if (!GameManager.Instance.hasAxeT1) // Award the player a Tier 1 Axe
                {
                    GameManager.Instance.hasAxeT1 = true;
                    GameManager.Instance.numAxeT1++;
                    print("You got a Tier 1 Axe! You now have a total of " + GameManager.Instance.numAxeT1);
                    cardUnlock.GetComponent<Image>().sprite = ImgAxeT1;
                    GameManager.Instance.offensiveCardsCollected++;

                }
                else
                {
                    GameManager.Instance.numAxeT1++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgAxeT1;
                }
            }
            if (randomNum == 3)
            {
                if (!GameManager.Instance.hasSpearT1) // Award the player a Tier 1 Spear
                {
                    GameManager.Instance.hasSpearT1 = true;
                    GameManager.Instance.numSpearT1++;
                    print("You got a Tier 1 Spear! You now have a total of " + GameManager.Instance.numSpearT1);
                    cardUnlock.GetComponent<Image>().sprite = ImgSpearT1;
                    GameManager.Instance.offensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numSpearT1++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgSpearT1;
                }
            }
            if (randomNum == 4)
            {
                if (!GameManager.Instance.hasClothT1) // Award the player a Tier 1 Cloth
                {
                    GameManager.Instance.hasClothT1 = true;
                    GameManager.Instance.numClothT1++;
                    print("You got a Tier 1 Cloth! You now have a total of " + GameManager.Instance.numClothT1);
                    cardUnlock.GetComponent<Image>().sprite = ImgClothT1;
                    GameManager.Instance.defensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numClothT1++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgClothT1;
                }
            }
            if (randomNum == 5)
            {
                if (!GameManager.Instance.hasLeatherT1) // Award the player a Tier 1 Leather
                {
                    GameManager.Instance.hasLeatherT1 = true;
                    GameManager.Instance.numLeatherT1++;
                    print("You got a Tier 1 Leather! You now have a total of " + GameManager.Instance.numLeatherT1);
                    cardUnlock.GetComponent<Image>().sprite = ImgLeatherT1;
                    GameManager.Instance.defensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numLeatherT1++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgLeatherT1;
                }
            }
            if (randomNum == 6)
            {
                if (!GameManager.Instance.hasPlateT1) // Award the player a Tier 1 Plate
                {
                    GameManager.Instance.hasPlateT1 = true;
                    GameManager.Instance.numPlateT1++;
                    print("You got a Tier 1 Plate! You now have a total of " + GameManager.Instance.numPlateT1);
                    cardUnlock.GetComponent<Image>().sprite = ImgPlateT1;
                    GameManager.Instance.defensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numPlateT1++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgPlateT1;
                }
            }
            if (randomNum == 7)
            {
                if (!GameManager.Instance.hasSwordT2) // Award the player a Tier 2 Sword
                {
                    GameManager.Instance.hasSwordT2 = true;
                    GameManager.Instance.numSwordT2++;
                    print("You got a Tier 2 Sword! You now have a total of " + GameManager.Instance.numSwordT2);
                    cardUnlock.GetComponent<Image>().sprite = ImgSwordT2;
                    GameManager.Instance.offensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numSwordT2++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgSwordT2;
                }
            }
            if (randomNum == 8)
            {
                if (!GameManager.Instance.hasAxeT2) // Award the player a Tier 2 Axe
                {
                    GameManager.Instance.hasAxeT2 = true;
                    GameManager.Instance.numAxeT2++;
                    print("You got a Tier 2 Axe! You now have a total of " + GameManager.Instance.numAxeT2);
                    cardUnlock.GetComponent<Image>().sprite = ImgAxeT2;
                    GameManager.Instance.offensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numAxeT2++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgAxeT2;
                }
            }
            if (randomNum == 9)
            {
                if (!GameManager.Instance.hasSpearT2) // Award the player a Tier 2 Spear
                {
                    GameManager.Instance.hasSpearT2 = true;
                    GameManager.Instance.numSpearT2++;
                    print("You got a Tier 2 Spear! You now have a total of " + GameManager.Instance.numSpearT2);
                    cardUnlock.GetComponent<Image>().sprite = ImgSpearT2;
                    GameManager.Instance.offensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numSpearT2++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgSpearT2;
                }
            }
            if (randomNum == 10)
            {
                if (!GameManager.Instance.hasClothT2) // Award the player a Tier 2 Cloth
                {
                    GameManager.Instance.hasClothT2 = true;
                    GameManager.Instance.numClothT2++;
                    print("You got a Tier 2 Cloth! You now have a total of " + GameManager.Instance.numClothT2);
                    cardUnlock.GetComponent<Image>().sprite = ImgClothT2;
                    GameManager.Instance.defensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numClothT2++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgClothT2;
                }
            }
            if (randomNum == 11)
            {
                if (!GameManager.Instance.hasLeatherT2) // Award the player a Tier 2 Leather
                {
                    GameManager.Instance.hasLeatherT2 = true;
                    GameManager.Instance.numLeatherT2++;
                    print("You got a Tier 2 Leather! You now have a total of " + GameManager.Instance.numLeatherT2);
                    cardUnlock.GetComponent<Image>().sprite = ImgLeatherT2;
                    GameManager.Instance.defensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numLeatherT2++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgLeatherT2;
                }
            }
            if (randomNum == 12)
            {
                if (!GameManager.Instance.hasPlateT2) // Award the player a Tier 2 Plate
                {
                    GameManager.Instance.hasPlateT2 = true;
                    GameManager.Instance.numPlateT2++;
                    print("You got a Tier 2 Plate! You now have a total of " + GameManager.Instance.numPlateT2);
                    cardUnlock.GetComponent<Image>().sprite = ImgPlateT2;
                    GameManager.Instance.defensiveCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numPlateT2++;
                    print(randomNum);
                    cardUnlock.GetComponent<Image>().sprite = ImgPlateT2;
                }
            }
            if (randomNum == 13)
            {
                if (!GameManager.Instance.hasHealingT1)
                {
                    GameManager.Instance.hasHealingT1 = true;
                    GameManager.Instance.numHealingT1++;
                    cardUnlock.GetComponent<Image>().sprite = ImgHealingT1;
                    GameManager.Instance.consumableCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numHealingT1++;
                    cardUnlock.GetComponent<Image>().sprite = ImgHealingT1;
                }
            }
            if (randomNum == 14)
            {
                if (!GameManager.Instance.hasHealingT2)
                {
                    GameManager.Instance.hasHealingT2 = true;
                    GameManager.Instance.numHealingT2++;
                    cardUnlock.GetComponent<Image>().sprite = ImgHealingT2;
                    GameManager.Instance.consumableCardsCollected++;
                }
                else
                {
                    GameManager.Instance.numHealingT2++;
                    cardUnlock.GetComponent<Image>().sprite = ImgHealingT2;
                }
            }
        }
    }
}
