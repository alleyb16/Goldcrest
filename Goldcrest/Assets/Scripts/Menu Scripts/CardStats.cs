using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardStats : MonoBehaviour
{
    public Loadout loadout; // Reference to Loadout script

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkStatUpdate(); // Updates players stats depending on equipped cards
    }

    void checkStatUpdate() // Applies stats for all active cards
    {
        // OFFENSIVE STATS
        #region
        if (GameManager.Instance.SwordT1) //  Stats for Sword tier 1
        {
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;

            GameManager.Instance.weaponDamage = 25;
            GameManager.Instance.attackCooldown = 40;
            GameManager.Instance.weaponRange = 2f;
            GameManager.Instance.weaponKnockback = 8;
        }
        if (GameManager.Instance.SwordT2) // Stats for Sword tier 2
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;

            GameManager.Instance.weaponDamage = 30;
            GameManager.Instance.attackCooldown = 50;
            GameManager.Instance.weaponRange = 2f;
            GameManager.Instance.weaponKnockback = 10;

        }
        if (GameManager.Instance.SwordT3) // Stats for Sword tier 3
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;

            GameManager.Instance.weaponDamage = 45;
            GameManager.Instance.attackCooldown = 65;
            GameManager.Instance.weaponRange = 2f;
            GameManager.Instance.weaponKnockback = 12;
        }
        if (GameManager.Instance.AxeT1) // Stats for Axe tier 1
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;

            GameManager.Instance.weaponDamage = 50;
            GameManager.Instance.attackCooldown = 25;
            GameManager.Instance.weaponRange = 1f;
            GameManager.Instance.weaponKnockback = 10;
        }
        if (GameManager.Instance.AxeT2) // Stats for Axe tier 2
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;

            GameManager.Instance.weaponDamage = 55;
            GameManager.Instance.attackCooldown = 30;
            GameManager.Instance.weaponRange = 1f;
            GameManager.Instance.weaponKnockback = 12;
        }
        if (GameManager.Instance.AxeT3) // Stats for Axe tier 3
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;

            GameManager.Instance.weaponDamage = 75;
            GameManager.Instance.attackCooldown = 45;
            GameManager.Instance.weaponRange = 1f;
            GameManager.Instance.weaponKnockback = 20;
        }
        if (GameManager.Instance.SpearT1) //Stats for Spear tier 1
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;

            GameManager.Instance.weaponDamage = 55;
            GameManager.Instance.attackCooldown = 15;
            GameManager.Instance.weaponRange = 3f;
            GameManager.Instance.weaponKnockback = 15;
        }
        if (GameManager.Instance.SpearT2) //Stats for Spear tier 2
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT3 = false;

            GameManager.Instance.weaponDamage = 65;
            GameManager.Instance.attackCooldown = 20;
            GameManager.Instance.weaponRange = 3f;
            GameManager.Instance.weaponKnockback = 20;
        }
        if (GameManager.Instance.SpearT3) //Stats for Spear tier 3
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;

            GameManager.Instance.weaponDamage = 70;
            GameManager.Instance.attackCooldown = 25;
            GameManager.Instance.weaponRange = 3f;
            GameManager.Instance.weaponKnockback = 30;
        }
        #endregion

        // DEFENSIVE STATS
        #region
        if (GameManager.Instance.ClothT1) // Stats for Cloth tier 1
        {
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;

            GameManager.Instance.playerMaxHealth = 115;
            GameManager.Instance.moveSpeed = 6.5f;
            GameManager.Instance.dodgeForce = 50*5;
        }
        if (GameManager.Instance.ClothT2) // Stats for Cloth tier 2
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;

            GameManager.Instance.playerMaxHealth = 120;
            GameManager.Instance.moveSpeed = 7f;
            GameManager.Instance.dodgeForce = 60*5;
        }
        if (GameManager.Instance.ClothT3) // Stats for Cloth tier 3
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;

            GameManager.Instance.playerMaxHealth = 125;
            GameManager.Instance.moveSpeed = 7.5f;
            GameManager.Instance.dodgeForce = 70*5;
        }
        if (GameManager.Instance.LeatherT1) // Stats for Leather tier 1
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;

            GameManager.Instance.playerMaxHealth = 125;
            GameManager.Instance.moveSpeed = 4.5f;
            GameManager.Instance.dodgeForce = 45*5;
        }
        if (GameManager.Instance.LeatherT2) // Stats for Leather tier 2
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;

            GameManager.Instance.playerMaxHealth = 135;
            GameManager.Instance.moveSpeed = 5;
            GameManager.Instance.dodgeForce = 50*5;
        }
        if (GameManager.Instance.LeatherT3) // Stats for Leather tier 3
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;

            GameManager.Instance.playerMaxHealth = 150;
            GameManager.Instance.moveSpeed = 6;
            GameManager.Instance.dodgeForce = 55*5;
        }
        if (GameManager.Instance.PlateT1) //Stats for Plate tier 1
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;

            GameManager.Instance.playerMaxHealth = 150;
            GameManager.Instance.moveSpeed = 4;
            GameManager.Instance.dodgeForce = 40*5;
        }
        if (GameManager.Instance.PlateT2) //Stats for Plate tier 2
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT3 = false;

            GameManager.Instance.playerMaxHealth = 175;
            GameManager.Instance.moveSpeed = 4.5f;
            GameManager.Instance.dodgeForce = 45*5;
        }
        if (GameManager.Instance.PlateT3) //Stats for Plate tier 3
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;

            GameManager.Instance.playerMaxHealth = 200;
            GameManager.Instance.moveSpeed = 5;
            GameManager.Instance.dodgeForce = 50*5;
        }
        #endregion

        // CONSUMABLE CARDS
        #region
        if (GameManager.Instance.HealingT1) // stats for healing tier 1
        {
            GameManager.Instance.HealingT2 = false;
            GameManager.Instance.HealingT3 = false;

            GameManager.Instance.consumableCharges = 3;
            GameManager.Instance.consumableCooldown = 5f;
            GameManager.Instance.healingDone = 25;
        }

        if (GameManager.Instance.HealingT2) // stats for healing tier 2
        {
            GameManager.Instance.HealingT1 = false;
            GameManager.Instance.HealingT3 = false;

            GameManager.Instance.consumableCharges = 4;
            GameManager.Instance.consumableCooldown = 4f;
            GameManager.Instance.healingDone = 50;
        }

        if (GameManager.Instance.HealingT3) // stats for healing tier 3
        {
            GameManager.Instance.HealingT1 = false;
            GameManager.Instance.HealingT2 = false;

            GameManager.Instance.consumableCharges = 5;
            GameManager.Instance.consumableCooldown = 3f;
            GameManager.Instance.healingDone = 75;
        }
        #endregion
    }

    // ACTIVATE OFFENSIVE CARDS
    #region
    public void activateSwordT1() // sets Sword tier 1 active
    {
        if (GameManager.Instance.hasSwordT1)
        {
            GameManager.Instance.SwordT1 = true;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;
        }
    }
    public void activateSwordT2() // sets Sword tier 2 active
    {
        if (GameManager.Instance.hasSwordT2)
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = true;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;
        }
    }
    public void activateSwordT3() // sets Sword tier 3 active
    {
        if (GameManager.Instance.hasSwordT3)
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = true;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;
        }
    }
    public void activateAxeT1() // sets Axe tier 1 active
    {
        if (GameManager.Instance.hasAxeT1)
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = true;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;
        }
    }
    public void activateAxeT2() // sets Axe tier 2 active
    {
        if (GameManager.Instance.hasAxeT2)
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = true;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;
        }
    }
    public void activateAxeT3() // sets Axe tier 3 active
    {
        if (GameManager.Instance.hasAxeT3)
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = true;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;
        }
    }
    public void activateSpearT1() // sets Spear tier 1 active
    {
        if (GameManager.Instance.hasSpearT1)
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = true;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = false;
        }
    }
    public void activateSpearT2() // sets Spear tier 2 active
    {
        if (GameManager.Instance.hasSpearT2)
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = true;
            GameManager.Instance.SpearT3 = false;
        }
    }
    public void activateSpearT3() // sets Spear tier 3 active
    {
        if (GameManager.Instance.hasSpearT3)
        {
            GameManager.Instance.SwordT1 = false;
            GameManager.Instance.SwordT2 = false;
            GameManager.Instance.SwordT3 = false;
            GameManager.Instance.AxeT1 = false;
            GameManager.Instance.AxeT2 = false;
            GameManager.Instance.AxeT3 = false;
            GameManager.Instance.SpearT1 = false;
            GameManager.Instance.SpearT2 = false;
            GameManager.Instance.SpearT3 = true;
        }
    }
    #endregion

    // ACTIVATE DEFENSIVE CARDS
    #region
    public void activateClothT1() // sets cloth tier 1 active
    {
        if (GameManager.Instance.hasClothT1)
        {
            GameManager.Instance.ClothT1 = true;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;
        }
    }
    public void activateClothT2() // sets cloth tier 2 active
    {
        if (GameManager.Instance.hasClothT2)
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = true;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;
        }
    }
    public void activateClothT3() // sets cloth tier 3 active
    {
        if (GameManager.Instance.hasClothT3)
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = true;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;
        }
    }
    public void activateLeatherT1() // sets leather tier 1 active
    {
        if (GameManager.Instance.hasLeatherT1)
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = true;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;
        }
    }
    public void activateLeatherT2() // sets leather tier 2 active
    {
        if (GameManager.Instance.hasLeatherT2)
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = true;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;
        }
    }
    public void activateLeatherT3() // sets leather tier 3 active
    {
        if (GameManager.Instance.hasLeatherT3)
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = true;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;
        }
    }
    public void activatePlateT1() // sets plate tier 1 active
    {
        if (GameManager.Instance.hasPlateT1)
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = true;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = false;
        }
    }
    public void activatePlateT2() // sets plate tier 2 active
    {
        if (GameManager.Instance.hasPlateT2)
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = true;
            GameManager.Instance.PlateT3 = false;
        }
    }
    public void activatePlateT3() // sets plate tier 3 active
    {
        if (GameManager.Instance.hasPlateT3)
        {
            GameManager.Instance.ClothT1 = false;
            GameManager.Instance.ClothT2 = false;
            GameManager.Instance.ClothT3 = false;
            GameManager.Instance.LeatherT1 = false;
            GameManager.Instance.LeatherT2 = false;
            GameManager.Instance.LeatherT3 = false;
            GameManager.Instance.PlateT1 = false;
            GameManager.Instance.PlateT2 = false;
            GameManager.Instance.PlateT3 = true;
        }
    }
    #endregion

    // ACTIVATE CONSUMABLE CARDS
    #region
    public void activateHealingT1() // sets healing tier 1 active
    {
        if (GameManager.Instance.hasHealingT1)
        {
            GameManager.Instance.HealingT1 = true;
            GameManager.Instance.HealingT2 = false;
            GameManager.Instance.HealingT3 = false;
        }
    }
    public void activateHealingT2() // sets healing tier 2 active
    {
        if (GameManager.Instance.hasHealingT2)
        {
            GameManager.Instance.HealingT1 = false;
            GameManager.Instance.HealingT2 = true;
            GameManager.Instance.HealingT3 = false;
        }
    }
    public void activateHealingT3() // sets healing tier 3 active
    {
        if (GameManager.Instance.hasHealingT3)
        {
            GameManager.Instance.HealingT1 = false;
            GameManager.Instance.HealingT2 = false;
            GameManager.Instance.HealingT3 = true;
        }
    }
    #endregion
}
