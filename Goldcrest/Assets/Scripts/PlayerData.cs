using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData {

    // This script should save and store game information to be loaded again

    // Basic inventory and level data
    #region
    public int totalCoins;
    public int levelsCompleted;

    public bool level1Completed;
    public bool level2Completed;
    public bool level3Completed;
    public bool level4Completed;

    public int lvl1Stars;
    public int lvl2Stars;
    public int lvl3Stars;
    public int lvl4Stars;

    public int offensiveCardsCollected;
    public int defensiveCardsCollected;
    public int consumableCardsCollected;

    public int level1Score;
    public float lvl1Rating;
    public int level2Score;
    public float lvl2Rating;
    public int level3Score;
    public float lvl3Rating;
    public int level4Score;
    public float lvl4Rating;

    public bool lvl2Unlocked;
    public bool lvl3Unlocked;
    public bool lvl4Unlocked;
    #endregion
    // Card data
    #region
    public bool hasSwordT1;
    public bool hasSwordT2;
    public bool hasSwordT3;
    public bool hasAxeT1;
    public bool hasAxeT2;
    public bool hasAxeT3;
    public bool hasSpearT1;
    public bool hasSpearT2;
    public bool hasSpearT3;

    public bool hasClothT1;
    public bool hasClothT2;
    public bool hasClothT3;
    public bool hasLeatherT1;
    public bool hasLeatherT2;
    public bool hasLeatherT3;
    public bool hasPlateT1;
    public bool hasPlateT2;
    public bool hasPlateT3;

    public bool hasHealingT1;
    public bool hasHealingT2;
    public bool hasHealingT3;

    public int numSwordT1;
    public int numSwordT2;
    public int numSwordT3;
    public int numAxeT1;
    public int numAxeT2;
    public int numAxeT3;
    public int numSpearT1;
    public int numSpearT2;
    public int numSpearT3;

    public int numClothT1;
    public int numClothT2;
    public int numClothT3;
    public int numLeatherT1;
    public int numLeatherT2;
    public int numLeatherT3;
    public int numPlateT1;
    public int numPlateT2;
    public int numPlateT3;

    public int numHealingT1;
    public int numHealingT2;
    public int numHealingT3;

    public int addSwordT1;
    public int addSwordT2;
    public int addSwordT3;
    public int addAxeT1;
    public int addAxeT2;
    public int addAxeT3;
    public int addSpearT1;
    public int addSpearT2;
    public int addSpearT3;

    public int addClothT1;
    public int addClothT2;
    public int addClothT3;
    public int addLeatherT1;
    public int addLeatherT2;
    public int addLeatherT3;
    public int addPlateT1;
    public int addPlateT2;
    public int addPlateT3;

    public int addHealingT1;
    public int addHealingT2;
    public int addHealingT3;

    public bool SwordT1;
    public bool SwordT2;
    public bool SwordT3;
    public bool AxeT1;
    public bool AxeT2;
    public bool AxeT3;
    public bool SpearT1;
    public bool SpearT2;
    public bool SpearT3;

    public bool ClothT1;
    public bool ClothT2;
    public bool ClothT3;
    public bool LeatherT1;
    public bool LeatherT2;
    public bool LeatherT3;
    public bool PlateT1;
    public bool PlateT2;
    public bool PlateT3;

    public bool HealingT1;
    public bool HealingT2;
    public bool HealingT3;
    #endregion
    // Player stats
    #region
    // Weapon stats
    public int weaponDamage;
    public float weaponRange;
    public float attackCooldown;
    public float weaponKnockback;

    // Armor Stats
    public float playerMaxHealth;
    public float moveSpeed;
    public int dodgeForce;

    // Consumable stats
    public int consumableCharges;
    public int healingDone;
    public float consumableCooldown;
    #endregion

    public PlayerData (GameManager gm)
    {
        // Basic inventory and level data
        #region

        totalCoins = gm.totalCoins;
        levelsCompleted = gm.levelsCompleted;

        level1Completed = gm.level1Completed;
        level2Completed = gm.level2Completed;
        level3Completed = gm.level3Completed;
        level4Completed = gm.level4Completed;

        lvl1Stars = gm.lvl1Stars;
        lvl2Stars = gm.lvl2Stars;
        lvl3Stars = gm.lvl3Stars;
        lvl4Stars = gm.lvl4Stars;

        offensiveCardsCollected = gm.offensiveCardsCollected;
        defensiveCardsCollected = gm.defensiveCardsCollected;
        consumableCardsCollected = gm.consumableCardsCollected;

        level1Score = gm.level1Score;
        lvl1Rating = gm.lvl1Rating;

        level2Score = gm.level2Score;
        lvl2Rating = gm.lvl2Rating;

        level3Score = gm.level3Score;
        lvl3Rating = gm.lvl3Rating;
        #endregion

        // Card data
        #region
        hasSwordT1 = gm.hasSwordT1;
        hasSwordT2 = gm.hasSwordT2;
        hasSwordT3 = gm.hasSwordT3;
        hasAxeT1 = gm.hasAxeT1;
        hasAxeT2 = gm.hasAxeT2;
        hasAxeT3 = gm.hasAxeT3;
        hasSpearT1 = gm.hasSpearT1;
        hasSpearT2 = gm.hasSpearT2;
        hasSpearT3 = gm.hasSpearT3;

        hasClothT1 = gm.hasClothT1;
        hasClothT2 = gm.hasClothT2;
        hasClothT3 = gm.hasClothT3;
        hasLeatherT1 = gm.hasLeatherT1;
        hasLeatherT2 = gm.hasLeatherT2;
        hasLeatherT3 = gm.hasLeatherT3;
        hasPlateT1 = gm.hasPlateT1;
        hasPlateT2 = gm.hasPlateT2;
        hasPlateT3 = gm.hasPlateT3;

        hasHealingT1 = gm.hasHealingT1;
        hasHealingT2 = gm.hasHealingT2;
        hasHealingT3 = gm.hasHealingT3;

        numSwordT1 = gm.numSwordT1;
        numSwordT2 = gm.numSwordT2;
        numSwordT3 = gm.numSwordT3;
        numAxeT1 = gm.numAxeT1;
        numAxeT2 = gm.numAxeT2;
        numAxeT3 = gm.numAxeT3;
        numSpearT1 = gm.numSpearT1;
        numSpearT2 = gm.numSpearT2;
        numSpearT3 = gm.numSpearT3;

        numClothT1 = gm.numClothT1;
        numClothT2 = gm.numClothT2;
        numClothT3 = gm.numClothT3;
        numLeatherT1 = gm.numLeatherT1;
        numLeatherT2 = gm.numLeatherT2;
        numLeatherT3 = gm.numLeatherT3;
        numPlateT1 = gm.numPlateT1;
        numPlateT2 = gm.numPlateT2;
        numPlateT3 = gm.numPlateT3;

        numHealingT1 = gm.numHealingT1;
        numHealingT2 = gm.numHealingT2;
        numHealingT3 = gm.numHealingT3;

        addSwordT1 = gm.addSwordT1;
        addSwordT2 = gm.addSwordT2;
        addSwordT3 = gm.addSwordT3;
        addAxeT1 = gm.addAxeT1;
        addAxeT2 = gm.addAxeT2;
        addAxeT3 = gm.addAxeT3;
        addSpearT1 = gm.addSpearT1;
        addSpearT2 = gm.addSpearT2;
        addSpearT3 = gm.addSpearT3;

        addClothT1 = gm.addClothT1;
        addClothT2 = gm.addClothT2;
        addClothT3 = gm.addClothT3;
        addLeatherT1 = gm.addLeatherT1;
        addLeatherT2 = gm.addLeatherT2;
        addLeatherT3 = gm.addLeatherT3;
        addPlateT1 = gm.addPlateT1;
        addPlateT2 = gm.addPlateT2;
        addPlateT3 = gm.addPlateT3;

        addHealingT1 = gm.addHealingT1;
        addHealingT2 = gm.addHealingT2;
        addHealingT3 = gm.addHealingT3;

        // equipped cards
        SwordT1 = gm.SwordT1;
        SwordT2 = gm.SwordT2;
        SwordT3 = gm.SwordT3;
        AxeT1 = gm.AxeT1;
        AxeT2 = gm.AxeT2;
        AxeT3 = gm.AxeT3;
        SpearT1 = gm.SpearT1;
        SpearT2 = gm.SpearT2;
        SpearT3 = gm.SpearT3;

        ClothT1 = gm.ClothT1;
        ClothT2 = gm.ClothT2;
        ClothT3 = gm.ClothT3;
        LeatherT1 = gm.LeatherT1;
        LeatherT2 = gm.LeatherT2;
        LeatherT3 = gm.LeatherT3;
        PlateT1 = gm.PlateT1;
        PlateT2 = gm.PlateT2;
        PlateT3 = gm.PlateT3;

        HealingT1 = gm.HealingT1;
        HealingT2 = gm.HealingT2;
        HealingT3 = gm.HealingT3;
        #endregion

        // Player Stats
        #region
        weaponDamage = gm.weaponDamage;
        weaponRange = gm.weaponRange;
        attackCooldown = gm.attackCooldown;
        weaponKnockback = gm.weaponKnockback;

        playerMaxHealth = gm.playerMaxHealth;
        moveSpeed = gm.moveSpeed;
        dodgeForce = gm.dodgeForce;

        consumableCharges = gm.consumableCharges;
        healingDone = gm.healingDone;
        consumableCooldown = gm.consumableCooldown;

        #endregion
    }
}
