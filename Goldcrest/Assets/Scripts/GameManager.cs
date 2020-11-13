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
    public bool level0Completed;
    public bool level1Completed;
    public bool level2Completed;
    public bool level3Completed;
    public bool level4Completed;

    public int lvl0Stars = 0;
    public int lvl1Stars = 0;
    public int lvl2Stars = 0;
    public int lvl3Stars = 0;
    public int lvl4Stars = 0;

    public int offensiveCardsCollected = 1;
    public int defensiveCardsCollected = 1;
    public int consumableCardsCollected = 1;

    //Level scores
    public int currentScore;
    public int level0Score = 0;
    public int level1Score = 0;
    public int level2Score = 0;
    public int level3Score = 0;
    public int level4Score = 0;

    public float lvl0Rating = 0;
    public float lvl1Rating = 0;
    public float lvl2Rating = 0;
    public float lvl3Rating = 0;
    public float lvl4Rating = 0;

    public bool lvl2Unlocked = false;
    public bool lvl3Unlocked = false;
    public bool lvl4Unlocked = false;

    public bool inLevel1 = false;
    public bool inLevel2 = false;
    public bool inLevel3 = false;
    public bool inLevel4 = false;
    public bool inDemo = false;


    // Unlocked Cards
    #region
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
    #endregion

    // Number of cards owned
    #region
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

    // Calculates total cards collected to display in inventory
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
    #endregion

    // Equipped Cards
    #region
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
    #endregion

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
    public bool isWalking = false;
    public bool isAttacking = false;
    public bool isDodging = false;
    public bool isDrinking = false;
    public bool isStunned = false;
    public bool isDead = false;

    public bool hasKey = false;

    public bool bossDead = false;

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

    public void level0Rating()
    {
        lvl0Rating = level0Score / 700f * 100f;
    }

    public void level1Rating()
    {
        lvl1Rating = Mathf.Round(level1Score / 1200f * 100f);
    }
    
    public void level2Rating()
    {
        lvl2Rating = level2Score / 1500f * 100f;
    }

    public void level3Rating()
    {
        lvl3Rating = level3Score / 1500f * 100f;
    }

    public void level4Rating()
    {
        lvl4Rating = level4Score / 500f * 100f;
    }
    

    public void SaveGame()
    {
        SaveSystem.SaveGame(this);
    }
    public void LoadGame()
    {
        PlayerData data = SaveSystem.LoadGame();

        // basic inventory and levels
        totalCoins = data.totalCoins;
        levelsCompleted = data.levelsCompleted;

        level1Completed = data.level1Completed;
        level2Completed = data.level2Completed;
        level3Completed = data.level3Completed;
        level4Completed = data.level4Completed;

        lvl1Stars = data.lvl1Stars;
        lvl2Stars = data.lvl2Stars;
        lvl3Stars = data.lvl3Stars;
        lvl4Stars = data.lvl3Stars;

        offensiveCardsCollected = data.offensiveCardsCollected;
        defensiveCardsCollected = data.defensiveCardsCollected;
        consumableCardsCollected = data.consumableCardsCollected;

        level1Score = data.level1Score;
        lvl1Rating = data.lvl1Rating;
        level2Score = data.level2Score;
        lvl2Rating = data.lvl2Rating;
        level3Score = data.level3Score;
        lvl3Rating = data.lvl3Rating;
        level4Score = data.level4Score;
        lvl4Rating = data.lvl4Rating;

        lvl2Unlocked = data.lvl2Unlocked;
        lvl3Unlocked = data.lvl3Unlocked;
        lvl4Unlocked = data.lvl4Unlocked;

        // card data
        hasSwordT1 = data.hasSwordT1;
        hasSwordT2 = data.hasSwordT2;
        hasSwordT3 = data.hasSwordT3;
        hasAxeT1 = data.hasAxeT1;
        hasAxeT2 = data.hasAxeT2;
        hasAxeT3 = data.hasAxeT3;
        hasSpearT1 = data.hasSpearT1;
        hasSpearT2 = data.hasSpearT2;
        hasSpearT3 = data.hasSpearT3;

        hasClothT1 = data.hasClothT1;
        hasClothT2 = data.hasClothT2;
        hasClothT3 = data.hasClothT3;
        hasLeatherT1 = data.hasLeatherT1;
        hasLeatherT2 = data.hasLeatherT2;
        hasLeatherT3 = data.hasLeatherT3;
        hasPlateT1 = data.hasPlateT1;
        hasPlateT2 = data.hasPlateT2;
        hasPlateT3 = data.hasPlateT3;

        hasHealingT1 = data.hasHealingT1;
        hasHealingT2 = data.hasHealingT2;
        hasHealingT3 = data.hasHealingT3;

        numSwordT1 = data.numSwordT1;
        numSwordT2 = data.numSwordT2;
        numSwordT3 = data.numSwordT3;
        numAxeT1 = data.numAxeT1;
        numAxeT2 = data.numAxeT2;
        numAxeT3 = data.numAxeT3;
        numSpearT1 = data.numSpearT1;
        numSpearT2 = data.numSpearT2;
        numSpearT3 = data.numSpearT3;

        numClothT1 = data.numClothT1;
        numClothT2 = data.numClothT2;
        numClothT3 = data.numClothT3;
        numLeatherT1 = data.numLeatherT1;
        numLeatherT2 = data.numLeatherT2;
        numLeatherT3 = data.numLeatherT3;
        numPlateT1 = data.numPlateT1;
        numPlateT2 = data.numPlateT2;
        numPlateT3 = data.numPlateT3;

        numHealingT1 = data.numHealingT1;
        numHealingT2 = data.numHealingT2;
        numHealingT3 = data.numHealingT3;

        addSwordT1 = data.addSwordT1;
        addSwordT2 = data.addSwordT2;
        addSwordT3 = data.addSwordT3;
        addAxeT1 = data.addAxeT1;
        addAxeT2 = data.addAxeT2;
        addAxeT3 = data.addAxeT3;
        addSpearT1 = data.addSpearT1;
        addSpearT2 = data.addSpearT2;
        addSpearT3 = data.addSpearT3;

        addClothT1 = data.addClothT1;
        addClothT2 = data.addClothT2;
        addClothT3 = data.addClothT3;
        addLeatherT1 = data.addLeatherT1;
        addLeatherT2 = data.addLeatherT2;
        addLeatherT3 = data.addLeatherT3;
        addPlateT1 = data.addPlateT1;
        addPlateT2 = data.addPlateT2;
        addPlateT3 = data.addPlateT3;

        addHealingT1 = data.addHealingT1;
        addHealingT2 = data.addHealingT2;
        addHealingT3 = data.addHealingT3;

        SwordT1 = data.SwordT1;
        SwordT2 = data.SwordT2;
        SwordT3 = data.SwordT3;
        AxeT1 = data.AxeT1;
        AxeT2 = data.AxeT2;
        AxeT3 = data.AxeT3;
        SpearT1 = data.SpearT1;
        SpearT2 = data.SpearT2;
        SpearT3 = data.SpearT3;

        ClothT1 = data.ClothT1;
        ClothT2 = data.ClothT2;
        ClothT3 = data.ClothT3;
        LeatherT1 = data.LeatherT1;
        LeatherT2 = data.LeatherT2;
        LeatherT3 = data.LeatherT3;
        PlateT1 = data.PlateT1;
        PlateT2 = data.PlateT2;
        PlateT3 = data.PlateT3;

        HealingT1 = data.HealingT1;
        HealingT2 = data.HealingT2;
        HealingT3 = data.HealingT3;

        // Player stats
        weaponDamage = data.weaponDamage;
        weaponRange = data.weaponRange;
        attackCooldown = data.attackCooldown;
        weaponKnockback = data.weaponKnockback;

        playerMaxHealth = data.playerMaxHealth;
        moveSpeed = data.moveSpeed;
        dodgeForce = data.dodgeForce;

        consumableCharges = data.consumableCharges;
        healingDone = data.healingDone;
        consumableCooldown = data.consumableCooldown;
    }

    public void ResetProgress()
    {
        // basic inventory and levels
        totalCoins = 0;
        levelsCompleted = 0;

        level1Completed = false;
        level2Completed = false;
        level3Completed = false;
        level4Completed = false;

        lvl1Stars = 0;
        lvl2Stars = 0;
        lvl3Stars = 0;
        lvl4Stars = 0;

        offensiveCardsCollected = 1;
        defensiveCardsCollected = 1;
        consumableCardsCollected = 1;

        level1Score = 0;
        lvl1Rating = 0;

        lvl2Unlocked = false;

        // card data
       /* hasSwordT1 = data.hasSwordT1;
        hasSwordT2 = data.hasSwordT2;
        hasSwordT3 = data.hasSwordT3;
        hasAxeT1 = data.hasAxeT1;
        hasAxeT2 = data.hasAxeT2;
        hasAxeT3 = data.hasAxeT3;
        hasSpearT1 = data.hasSpearT1;
        hasSpearT2 = data.hasSpearT2;
        hasSpearT3 = data.hasSpearT3;

        hasClothT1 = data.hasClothT1;
        hasClothT2 = data.hasClothT2;
        hasClothT3 = data.hasClothT3;
        hasLeatherT1 = data.hasLeatherT1;
        hasLeatherT2 = data.hasLeatherT2;
        hasLeatherT3 = data.hasLeatherT3;
        hasPlateT1 = data.hasPlateT1;
        hasPlateT2 = data.hasPlateT2;
        hasPlateT3 = data.hasPlateT3;

        hasHealingT1 = data.hasHealingT1;
        hasHealingT2 = data.hasHealingT2;
        hasHealingT3 = data.hasHealingT3;

        numSwordT1 = data.numSwordT1;
        numSwordT2 = data.numSwordT2;
        numSwordT3 = data.numSwordT3;
        numAxeT1 = data.numAxeT1;
        numAxeT2 = data.numAxeT2;
        numAxeT3 = data.numAxeT3;
        numSpearT1 = data.numSpearT1;
        numSpearT2 = data.numSpearT2;
        numSpearT3 = data.numSpearT3;

        numClothT1 = data.numClothT1;
        numClothT2 = data.numClothT2;
        numClothT3 = data.numClothT3;
        numLeatherT1 = data.numLeatherT1;
        numLeatherT2 = data.numLeatherT2;
        numLeatherT3 = data.numLeatherT3;
        numPlateT1 = data.numPlateT1;
        numPlateT2 = data.numPlateT2;
        numPlateT3 = data.numPlateT3;

        numHealingT1 = data.numHealingT1;
        numHealingT2 = data.numHealingT2;
        numHealingT3 = data.numHealingT3;

        addSwordT1 = data.addSwordT1;
        addSwordT2 = data.addSwordT2;
        addSwordT3 = data.addSwordT3;
        addAxeT1 = data.addAxeT1;
        addAxeT2 = data.addAxeT2;
        addAxeT3 = data.addAxeT3;
        addSpearT1 = data.addSpearT1;
        addSpearT2 = data.addSpearT2;
        addSpearT3 = data.addSpearT3;

        addClothT1 = data.addClothT1;
        addClothT2 = data.addClothT2;
        addClothT3 = data.addClothT3;
        addLeatherT1 = data.addLeatherT1;
        addLeatherT2 = data.addLeatherT2;
        addLeatherT3 = data.addLeatherT3;
        addPlateT1 = data.addPlateT1;
        addPlateT2 = data.addPlateT2;
        addPlateT3 = data.addPlateT3;

        addHealingT1 = data.addHealingT1;
        addHealingT2 = data.addHealingT2;
        addHealingT3 = data.addHealingT3;

        SwordT1 = data.SwordT1;
        SwordT2 = data.SwordT2;
        SwordT3 = data.SwordT3;
        AxeT1 = data.AxeT1;
        AxeT2 = data.AxeT2;
        AxeT3 = data.AxeT3;
        SpearT1 = data.SpearT1;
        SpearT2 = data.SpearT2;
        SpearT3 = data.SpearT3;

        ClothT1 = data.ClothT1;
        ClothT2 = data.ClothT2;
        ClothT3 = data.ClothT3;
        LeatherT1 = data.LeatherT1;
        LeatherT2 = data.LeatherT2;
        LeatherT3 = data.LeatherT3;
        PlateT1 = data.PlateT1;
        PlateT2 = data.PlateT2;
        PlateT3 = data.PlateT3;

        HealingT1 = data.HealingT1;
        HealingT2 = data.HealingT2;
        HealingT3 = data.HealingT3;

        // Player stats
        weaponDamage = data.weaponDamage;
        weaponRange = data.weaponRange;
        attackCooldown = data.attackCooldown;
        weaponKnockback = data.weaponKnockback;

        playerMaxHealth = data.playerMaxHealth;
        moveSpeed = data.moveSpeed;
        dodgeForce = data.dodgeForce;

        consumableCharges = data.consumableCharges;
        healingDone = data.healingDone;
        consumableCooldown = data.consumableCooldown;
        */
    }
}
