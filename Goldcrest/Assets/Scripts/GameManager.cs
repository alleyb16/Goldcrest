using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            //creates the instance
            if (_instance == null)
            {
                GameObject gm = new GameObject("GameManager");
                gm.AddComponent<GameManager>();
            }

            return _instance;
        }
    }

    // GAME MANAGER VARIABLES - store player stats (health, weapon type, weapon damage, etc.)

    //private bool tutorial = true; // For first launch

    public int totalCoins = 0;
    public int coinsCollected;

    public int levelsCompleted = 0;
    public bool level1Completed;
    public bool level2Completed;
    public bool level3Completed;
    public bool level4Completed;

    public int lvl1Stars = 0;
    public int lvl2Stars = 0;
    public int lvl3Stars = 0;
    public int lvl4Stars = 0;

    public int offensiveCardsCollected = 1;
    public int defensiveCardsCollected = 1;
    public int consumableCardsCollected = 1;

    //Level scores
    public int currentScore;
    public int level1Score = 0;
    public float lvl1Rating = 0;

    public bool lvl2Unlocked = false;


    // Unlocked Cards
    // Offensive cards
    public bool hasSwordT1 = true;
    public bool hasSwordT2 = false;
    public bool hasSwordT3 = false;

    public bool hasAxeT1 = false;
    public bool hasAxeT2 = false;
    public bool hasAxeT3 = false;

    public bool hasSpearT1 = false;
    public bool hasSpearT2 = false;
    public bool hasSpearT3 = false;

    // Defensive cards
    public bool hasClothT1 = true;
    public bool hasClothT2 = false;
    public bool hasClothT3 = false;

    public bool hasLeatherT1 = false;
    public bool hasLeatherT2 = false;
    public bool hasLeatherT3 = false;

    public bool hasPlateT1 = false;
    public bool hasPlateT2 = false;
    public bool hasPlateT3 = false;

    // Consumable cards
    public bool hasHealingT1 = true;
    public bool hasHealingT2 = false;
    public bool hasHealingT3 = false;


    // Number of cards owned
    public int numSwordT1 = 1;
    public int numSwordT2 = 0;
    public int numSwordT3 = 0;

    public int numAxeT1 = 0;
    public int numAxeT2 = 0;
    public int numAxeT3 = 0;

    public int numSpearT1 = 0;
    public int numSpearT2 = 0;
    public int numSpearT3 = 0;

    public int numClothT1 = 1;
    public int numClothT2 = 0;
    public int numClothT3 = 0;

    public int numLeatherT1 = 0;
    public int numLeatherT2 = 0;
    public int numLeatherT3 = 0;

    public int numPlateT1 = 0;
    public int numPlateT2 = 0;
    public int numPlateT3 = 0;

    public int numHealingT1 = 1;
    public int numHealingT2 = 0;
    public int numHealingT3 = 0;

    public int addSwordT1 = 1;
    public int addSwordT2 = 0;
    public int addSwordT3 = 0;
    public int addAxeT1 = 0;
    public int addAxeT2 = 0;
    public int addAxeT3 = 0;
    public int addSpearT1 = 0;
    public int addSpearT2 = 0;
    public int addSpearT3 = 0;

    public int addClothT1 = 1;
    public int addClothT2 = 0;
    public int addClothT3 = 0;
    public int addLeatherT1 = 0;
    public int addLeatherT2 = 0;
    public int addLeatherT3 = 0;
    public int addPlateT1 = 0;
    public int addPlateT2 = 0;
    public int addPlateT3 = 0;

    public int addHealingT1 = 1;
    public int addHealingT2 = 0;
    public int addHealingT3 = 0;

    // Equipped Cards
    // Offensive cards
    public bool SwordT1 = true;
    public bool SwordT2 = false;
    public bool SwordT3 = false;

    public bool AxeT1 = false;
    public bool AxeT2 = false;
    public bool AxeT3 = false;

    public bool SpearT1 = false;
    public bool SpearT2 = false;
    public bool SpearT3 = false;

    // Defensive cards
    public bool ClothT1 = true;
    public bool ClothT2 = false;
    public bool ClothT3 = false;

    public bool LeatherT1 = false;
    public bool LeatherT2 = false;
    public bool LeatherT3 = false;

    public bool PlateT1 = false;
    public bool PlateT2 = false;
    public bool PlateT3 = false;

    // Consumable cards
    public bool HealingT1 = true;
    public bool HealingT2 = false;
    public bool HealingT3 = false;


    // Player stats
    // weapon stats
    public int weaponDamage = 20;
    public float weaponRange = 1f;
    public float attackCooldown = 1f;
    public float weaponKnockback = 20f;

    // armor stats
    public float playerMaxHealth = 100f;
    public float playerHealth = 100f;
    public float moveSpeed = 5f;
    public int dodgeForce = 500;

    // consumable stats
    public int consumableCharges;
    public int healingDone;
    public float consumableCooldown = 5f;

    //Animation states
    public bool isMoving = false;
    public bool isAttacking = false;
    public bool isDodging = false;
    public bool isDrinking = false;

    // Invuln state
    public bool invuln = false;


    private void Awake()
    {
            DontDestroyOnLoad(gameObject); // This keeps the game manager consistent throughout level swaps and stores values
            _instance = this;
            Application.targetFrameRate = 60;
    }

    public void depositCoins() // Stores coins collected from the end of the level
    {
        totalCoins += coinsCollected;
        coinsCollected = 0;
    }

    public void level1Rating()
    {
        lvl1Rating = level1Score / 500f * 100f;
    }
}
