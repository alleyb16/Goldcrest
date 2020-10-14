using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
    public MainMenu menu;

    public int totalOffensiveCards;
    public int totalDefensiveCards;
    public int totalConsumableCards;

    public Image SwordT1Cover;
    public Image SwordT2Cover;
    public Image SwordT3Cover;
    public Image AxeT1Cover;
    public Image AxeT2Cover;
    public Image AxeT3Cover;
    public Image SpearT1Cover;
    public Image SpearT2Cover;
    public Image SpearT3Cover;

    public Image ClothT1Cover;
    public Image ClothT2Cover;
    public Image ClothT3Cover;
    public Image LeatherT1Cover;
    public Image LeatherT2Cover;
    public Image LeatherT3Cover;
    public Image PlateT1Cover;
    public Image PlateT2Cover;
    public Image PlateT3Cover;

    public Image HealingT1Cover;
    public Image HealingT2Cover;
    public Image HealingT3Cover;

    public Text numSwordT1;
    public Text numSwordT2;
    public Text numSwordT3;
    public Text numAxeT1;
    public Text numAxeT2;
    public Text numAxeT3;
    public Text numSpearT1;
    public Text numSpearT2;
    public Text numSpearT3;

    public Text numClothT1;
    public Text numClothT2;
    public Text numClothT3;
    public Text numLeatherT1;
    public Text numLeatherT2;
    public Text numLeatherT3;
    public Text numPlateT1;
    public Text numPlateT2;
    public Text numPlateT3;

    public Text numHealingT1;
    public Text numHealingT2;
    public Text numHealingT3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        revealCards();
        updateCardValues();
        calculateTotalCards();
        menu.updateInventory();
    }

    // Lock/unlock card covers
    public void revealCards()
    {
        // Offensive Card Covers
        if (GameManager.Instance.hasSwordT1) // Show SwordT1 if owned
        {
            SwordT1Cover.enabled = false;
            GameManager.Instance.addSwordT1 = 1; // adds value to total cards collected
        }
        else
        {
            SwordT1Cover.enabled = true; // Hide SwordT2 if not owned
            GameManager.Instance.addSwordT1 = 0;
        }

        if (GameManager.Instance.hasSwordT2) // Show SwordT2
        {
            SwordT2Cover.enabled = false;
            GameManager.Instance.addSwordT2 = 1;
        }
        else
        {
            SwordT2Cover.enabled = true; // Hide SwordT2
            GameManager.Instance.addSwordT2 = 0;
        }

        if (GameManager.Instance.hasSwordT3) // Show SwordT3
        {
            SwordT3Cover.enabled = false;
            GameManager.Instance.addSwordT3 = 1;
        }
        else
        {
            SwordT3Cover.enabled = true; // Hide SwordT3
            GameManager.Instance.addSwordT3 = 0;
        }

        if (GameManager.Instance.hasAxeT1) // Show AxeT1
        {
            AxeT1Cover.enabled = false;
            GameManager.Instance.addAxeT1 = 1;
        }
        else
        {
            AxeT1Cover.enabled = true; // Hide AxeT1
            GameManager.Instance.addAxeT1 = 0;
        }

        if (GameManager.Instance.hasAxeT2) // Show AxeT2
        {
            AxeT2Cover.enabled = false;
            GameManager.Instance.addAxeT2 = 1;
        }
        else
        {
            AxeT2Cover.enabled = true; // Hide AxeT2
            GameManager.Instance.addAxeT2 = 0;
        }

        if (GameManager.Instance.hasAxeT3) // Show AxeT3
        {
            AxeT3Cover.enabled = false;
            GameManager.Instance.addAxeT3 = 1;
        }
        else
        {
            AxeT3Cover.enabled = true; // Hide AxeT3
            GameManager.Instance.addAxeT3 = 0;
        }

        if (GameManager.Instance.hasSpearT1) // Show SpearT1
        {
            SpearT1Cover.enabled = false;
            GameManager.Instance.addSpearT1 = 1;
        }
        else
        {
            SpearT1Cover.enabled = true; // Hide SpearT1
            GameManager.Instance.addSpearT1 = 0;
        }

        if (GameManager.Instance.hasSpearT2) // Show SpearT2
        {
            SpearT2Cover.enabled = false;
            GameManager.Instance.addSpearT2 = 1;
        }
        else
        {
            SpearT2Cover.enabled = true; // Hide SpearT2
            GameManager.Instance.addSpearT2 = 0;
        }

        if (GameManager.Instance.hasSpearT3) // Show SpearT3
        {
            SpearT3Cover.enabled = false;
            GameManager.Instance.addSpearT3 = 1;
        }
        else
        {
            SpearT3Cover.enabled = true; // Hide SpearT3
            GameManager.Instance.addSpearT3 = 0;
        }

        // Defensive Card Covers
        if (GameManager.Instance.hasClothT1) // Show ClothT1 if owned
        {
            ClothT1Cover.enabled = false;
            GameManager.Instance.addClothT1 = 1;
        }
        else
        {
            ClothT1Cover.enabled = true; // Hide ClothT1 if not owned
            GameManager.Instance.addClothT1 = 0;
        }

        if (GameManager.Instance.hasClothT2) // Show ClothT2
        {
            ClothT2Cover.enabled = false;
            GameManager.Instance.addClothT2 = 1;
        }
        else
        {
            ClothT2Cover.enabled = true; // Hide ClothT2
            GameManager.Instance.addClothT2 = 0;
        }

        if (GameManager.Instance.hasClothT3) // Show ClothT3
        {
            ClothT3Cover.enabled = false;
            GameManager.Instance.addClothT3 = 1;
        }
        else
        {
            ClothT3Cover.enabled = true; // Hide ClothT3
            GameManager.Instance.addClothT3 = 0;
        }

        if (GameManager.Instance.hasLeatherT1) // Show LeatherT1
        {
            LeatherT1Cover.enabled = false;
            GameManager.Instance.addLeatherT1 = 1;
        }
        else
        {
            LeatherT1Cover.enabled = true; // Hide LeatherT1
            GameManager.Instance.addLeatherT1 = 0;
        }

        if (GameManager.Instance.hasLeatherT2) // Show LeatherT2
        {
            LeatherT2Cover.enabled = false;
            GameManager.Instance.addLeatherT2 = 1;
        }
        else
        {
            LeatherT2Cover.enabled = true; // Hide LeatherT2
            GameManager.Instance.addLeatherT2 = 0;
        }

        if (GameManager.Instance.hasLeatherT3) // Show LeatherT3
        {
            LeatherT3Cover.enabled = false;
            GameManager.Instance.addLeatherT3 = 1;
        }
        else
        {
            LeatherT3Cover.enabled = true; // Hide LeatherT3
            GameManager.Instance.addLeatherT3 = 0;
        }

        if (GameManager.Instance.hasPlateT1) // Show PlateT1
        {
            PlateT1Cover.enabled = false;
            GameManager.Instance.addPlateT1 = 1;
        }
        else
        {
            PlateT1Cover.enabled = true; // Hide PlateT1
            GameManager.Instance.addPlateT1 = 0;
        }

        if (GameManager.Instance.hasPlateT2) // Show PlateT2
        {
            PlateT2Cover.enabled = false;
            GameManager.Instance.addPlateT2 = 1;
        }
        else
        {
            PlateT2Cover.enabled = true; // Hide PlateT2
            GameManager.Instance.addPlateT2 = 0;
        }

        if (GameManager.Instance.hasPlateT3) // Show PlateT3
        {
            PlateT3Cover.enabled = false;
            GameManager.Instance.addPlateT3 = 1;
        }
        else
        {
            PlateT3Cover.enabled = true; // Hide PlateT3
            GameManager.Instance.addPlateT3 = 0;
        }

        // Consumable Card Covers
        if (GameManager.Instance.hasHealingT1)
        {
            HealingT1Cover.enabled = false;
            GameManager.Instance.addHealingT1 = 1;
        }
        else
        {
            HealingT1Cover.enabled = true;
            GameManager.Instance.addHealingT1 = 0;
        }

        if (GameManager.Instance.hasHealingT2)
        {
            HealingT2Cover.enabled = false;
            GameManager.Instance.addHealingT2 = 1;
        }
        else
        {
            HealingT2Cover.enabled = true;
            GameManager.Instance.addHealingT2 = 0;
        }

        if (GameManager.Instance.hasHealingT3)
        {
            HealingT3Cover.enabled = false;
            GameManager.Instance.addHealingT3 = 1;
        }
        else
        {
            HealingT3Cover.enabled = true;
            GameManager.Instance.addHealingT3 = 0;
        }
    }

    // Buy/Craft offensive cards
    public void buySwordT1()
    {
        // if total coins >= 100
        // add numSwordT1
        // set hasSwordT1 true if was false
        // remove 100 from total coins
        // refresh menu.updateInventory

        if (GameManager.Instance.totalCoins >= 100) // if player has enough gold
        {
            GameManager.Instance.numSwordT1++; // add one to tier 1 sword count
            if (!GameManager.Instance.hasSwordT1) // if player doesn't have a copy of this card
            {
                GameManager.Instance.hasSwordT1 = true; // set card status as collected
            }
            GameManager.Instance.totalCoins -= 100; // subtract coin cost
            menu.updateInventory(); // update inventory statuses
            updateCardValues();
            revealCards();
        }
    }

    public void craftSwordT2()
    {
        // if numSwordT1 >= 2 && total coins >= 200
        // add numSwordT2
        // set hasSwordT2 true if was false
        // remove 200 from total coins
        // remove 2 from numSwordT1
        // if numSwordT1 == 0
        // set hasSwordT1 false
        // refresh menu.updateInventory

        if (GameManager.Instance.numSwordT1 >= 2 && GameManager.Instance.totalCoins >= 200)
        {
            GameManager.Instance.numSwordT2++;
            if (!GameManager.Instance.hasSwordT2)
            {
                GameManager.Instance.hasSwordT2 = true;
            }
            GameManager.Instance.totalCoins -= 200;
            GameManager.Instance.numSwordT1 -= 2;
            if (GameManager.Instance.numSwordT1 == 0)
            {
                GameManager.Instance.hasSwordT1 = false;
                //GameManager.Instance.offensiveCardsCollected--;
                GameManager.Instance.addSwordT1 = 0;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void craftSwordT3()
    {
        if (GameManager.Instance.numSwordT2 >= 2 && GameManager.Instance.totalCoins >= 300)
        {
            GameManager.Instance.numSwordT3++;
            if (!GameManager.Instance.hasSwordT3)
            {
                GameManager.Instance.hasSwordT3 = true;
            }
            GameManager.Instance.totalCoins -= 300;
            GameManager.Instance.numSwordT2 -= 2;
            if(GameManager.Instance.numSwordT2 == 0)
            {
                GameManager.Instance.hasSwordT2 = false;
                GameManager.Instance.offensiveCardsCollected--;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void buyAxeT1()
    {
        if (GameManager.Instance.totalCoins >= 100)
        {
            GameManager.Instance.numAxeT1++;
            if (!GameManager.Instance.hasAxeT1)
            {
                GameManager.Instance.hasAxeT1 = true;
            }
            GameManager.Instance.totalCoins -= 100;
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void craftAxeT2()
    {
        if (GameManager.Instance.numAxeT1 >= 2 && GameManager.Instance.totalCoins >= 200)
        {
            GameManager.Instance.numAxeT2++;
            if (!GameManager.Instance.hasAxeT2)
            {
                GameManager.Instance.hasAxeT2 = true;
            }
            GameManager.Instance.totalCoins -= 200;
            GameManager.Instance.numAxeT1 -= 2;
            if (GameManager.Instance.numAxeT1 == 0)
            {
                GameManager.Instance.addAxeT2 = 0;
                GameManager.Instance.hasAxeT1 = false;
                //GameManager.Instance.offensiveCardsCollected--;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void craftAxeT3()
    {
        if (GameManager.Instance.numAxeT2 >= 2 && GameManager.Instance.totalCoins >= 300)
        {
            GameManager.Instance.numAxeT3++;
            if (!GameManager.Instance.hasAxeT3)
            {
                GameManager.Instance.hasAxeT3 = true;
            }
            GameManager.Instance.totalCoins -= 300;
            GameManager.Instance.numAxeT2 -= 2;
            if (GameManager.Instance.numAxeT2 == 0)
            {
                GameManager.Instance.hasAxeT2 = false;
                GameManager.Instance.offensiveCardsCollected--;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void buySpearT1()
    {
        if (GameManager.Instance.totalCoins >= 100)
        {
            GameManager.Instance.numSpearT1++;
            if (!GameManager.Instance.hasSpearT1)
            {
                GameManager.Instance.hasSpearT1 = true;
            }
            GameManager.Instance.totalCoins -= 100;
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void craftSpearT2()
    {
        if (GameManager.Instance.numSpearT1 >= 2 && GameManager.Instance.totalCoins >= 200)
        {
            GameManager.Instance.numSpearT2++;
            if (!GameManager.Instance.hasSpearT2)
            {
                GameManager.Instance.hasSpearT2 = true;
            }
            GameManager.Instance.totalCoins -= 200;
            GameManager.Instance.numSpearT1 -= 2;
            if (GameManager.Instance.numSpearT1 == 0)
            {
                GameManager.Instance.hasSpearT1 = false;
                GameManager.Instance.offensiveCardsCollected--;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void craftSpearT3()
    {
        if (GameManager.Instance.numSpearT2 >= 2 && GameManager.Instance.totalCoins >= 300)
        {
            GameManager.Instance.numSpearT3++;
            if (!GameManager.Instance.hasSpearT3)
            {
                GameManager.Instance.hasSpearT3 = true;
            }
            GameManager.Instance.totalCoins -= 300;
            GameManager.Instance.numSpearT2 -= 2;
            if (GameManager.Instance.numSpearT2 == 0)
            {
                GameManager.Instance.hasSpearT2 = false;
                GameManager.Instance.offensiveCardsCollected--;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    // Buy/Craft Defensive Cards
    public void buyClothT1()
    {
        if (GameManager.Instance.totalCoins >= 100) // if player has enough gold
        {
            GameManager.Instance.numClothT1++; // add one to tier 1 sword count
            if (!GameManager.Instance.hasClothT1) // if player doesn't have a copy of this card
            {
                GameManager.Instance.hasSwordT1 = true; // set card status as collected
            }
            GameManager.Instance.totalCoins -= 100; // subtract coin cost
            menu.updateInventory(); // update inventory statuses
            updateCardValues();
            revealCards();
        }
    }

    public void craftClothT2()
    {
        if (GameManager.Instance.numClothT1 >= 2 && GameManager.Instance.totalCoins >= 200)
        {
            GameManager.Instance.numClothT2++;
            if (!GameManager.Instance.hasClothT2)
            {
                GameManager.Instance.hasClothT2 = true;
            }
            GameManager.Instance.totalCoins -= 200;
            GameManager.Instance.numClothT1 -= 2;
            if (GameManager.Instance.numClothT1 == 0)
            {
                GameManager.Instance.hasClothT1 = false;
                GameManager.Instance.defensiveCardsCollected--;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void craftClothT3()
    {
        if (GameManager.Instance.numClothT2 >= 2 && GameManager.Instance.totalCoins >= 300)
        {
            GameManager.Instance.numClothT3++;
            if (!GameManager.Instance.hasClothT3)
            {
                GameManager.Instance.hasClothT3 = true;
            }
            GameManager.Instance.totalCoins -= 300;
            GameManager.Instance.numClothT2 -= 2;
            if (GameManager.Instance.numClothT2 == 0)
            {
                GameManager.Instance.hasClothT2 = false;
                GameManager.Instance.defensiveCardsCollected--;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void buyLeatherT1()
    {
        if (GameManager.Instance.totalCoins >= 100) // if player has enough gold
        {
            GameManager.Instance.numLeatherT1++; // add one to tier 1 sword count
            if (!GameManager.Instance.hasLeatherT1) // if player doesn't have a copy of this card
            {
                GameManager.Instance.hasLeatherT1 = true; // set card status as collected
            }
            GameManager.Instance.totalCoins -= 100; // subtract coin cost
            menu.updateInventory(); // update inventory statuses
            updateCardValues();
            revealCards();
        }
    }

    public void craftLeatherT2()
    {
        if (GameManager.Instance.numLeatherT1 >= 2 && GameManager.Instance.totalCoins >= 200)
        {
            GameManager.Instance.numLeatherT2++;
            if (!GameManager.Instance.hasLeatherT2)
            {
                GameManager.Instance.hasLeatherT2 = true;
            }
            GameManager.Instance.totalCoins -= 200;
            GameManager.Instance.numLeatherT1 -= 2;
            if (GameManager.Instance.numLeatherT1 == 0)
            {
                GameManager.Instance.hasLeatherT1 = false;
                GameManager.Instance.defensiveCardsCollected--;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void craftLeatherT3()
    {
        if (GameManager.Instance.numLeatherT2 >= 2 && GameManager.Instance.totalCoins >= 300)
        {
            GameManager.Instance.numLeatherT3++;
            if (!GameManager.Instance.hasLeatherT3)
            {
                GameManager.Instance.hasLeatherT3 = true;
            }
            GameManager.Instance.totalCoins -= 300;
            GameManager.Instance.numLeatherT2 -= 2;
            if (GameManager.Instance.numLeatherT2 == 0)
            {
                GameManager.Instance.hasLeatherT2 = false;
                GameManager.Instance.defensiveCardsCollected--;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void buyPlateT1()
    {
        if (GameManager.Instance.totalCoins >= 100) // if player has enough gold
        {
            GameManager.Instance.numPlateT1++; // add one to tier 1 sword count
            if (!GameManager.Instance.hasPlateT1) // if player doesn't have a copy of this card
            {
                GameManager.Instance.hasPlateT1 = true; // set card status as collected
            }
            GameManager.Instance.totalCoins -= 100; // subtract coin cost
            menu.updateInventory(); // update inventory statuses
            updateCardValues();
            revealCards();
        }
    }

    public void craftPlateT2()
    {
        if (GameManager.Instance.numPlateT1 >= 2 && GameManager.Instance.totalCoins >= 200)
        {
            GameManager.Instance.numPlateT2++;
            if (!GameManager.Instance.hasPlateT2)
            {
                GameManager.Instance.hasPlateT2 = true;
            }
            GameManager.Instance.totalCoins -= 200;
            GameManager.Instance.numPlateT1 -= 2;
            if (GameManager.Instance.numPlateT1 == 0)
            {
                GameManager.Instance.hasPlateT1 = false;
                GameManager.Instance.defensiveCardsCollected--;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void craftPlateT3()
    {
        if (GameManager.Instance.numPlateT2 >= 2 && GameManager.Instance.totalCoins >= 300)
        {
            GameManager.Instance.numPlateT3++;
            if (!GameManager.Instance.hasPlateT3)
            {
                GameManager.Instance.hasPlateT3 = true;
            }
            GameManager.Instance.totalCoins -= 300;
            GameManager.Instance.numPlateT2 -= 2;
            if (GameManager.Instance.numPlateT2 == 0)
            {
                GameManager.Instance.hasPlateT2 = false;
                GameManager.Instance.defensiveCardsCollected--;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void buyHealingT1()
    {
        if (GameManager.Instance.totalCoins >= 100) // if player has enough gold
        {
            GameManager.Instance.numHealingT1++; // add one to tier 1 sword count
            if (!GameManager.Instance.hasHealingT1) // if player doesn't have a copy of this card
            {
                GameManager.Instance.hasHealingT1 = true; // set card status as collected
            }
            GameManager.Instance.totalCoins -= 100; // subtract coin cost
            menu.updateInventory(); // update inventory statuses
            updateCardValues();
            revealCards();
        }
    }

    public void craftHealingT2()
    {
        if (GameManager.Instance.numHealingT1 >= 2 && GameManager.Instance.totalCoins >= 200)
        {
            GameManager.Instance.numHealingT2++;
            if (!GameManager.Instance.hasHealingT2)
            {
                GameManager.Instance.hasHealingT2 = true;
            }
            GameManager.Instance.totalCoins -= 200;
            GameManager.Instance.numHealingT1 -= 2;
            if (GameManager.Instance.numHealingT1 == 0)
            {
                GameManager.Instance.hasHealingT1 = false;
                GameManager.Instance.consumableCardsCollected--;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void craftHealingT3()
    {
        if (GameManager.Instance.numHealingT2 >= 2 && GameManager.Instance.totalCoins >= 300)
        {
            GameManager.Instance.numHealingT3++;
            if (!GameManager.Instance.hasHealingT3)
            {
                GameManager.Instance.hasHealingT3 = true;
            }
            GameManager.Instance.totalCoins -= 300;
            GameManager.Instance.numHealingT2 -= 2;
            if (GameManager.Instance.numHealingT2 == 0)
            {
                GameManager.Instance.hasHealingT2 = false;
                GameManager.Instance.consumableCardsCollected--;
            }
            menu.updateInventory();
            updateCardValues();
            revealCards();
        }
    }

    public void updateCardValues()
    {
        numSwordT1.text = ("X " + GameManager.Instance.numSwordT1).ToString();
        numSwordT2.text = ("X " + GameManager.Instance.numSwordT2).ToString();
        numSwordT3.text = ("X " + GameManager.Instance.numSwordT3).ToString();
        numAxeT1.text = ("X " + GameManager.Instance.numAxeT1).ToString();
        numAxeT2.text = ("X " + GameManager.Instance.numAxeT2).ToString();
        numAxeT3.text = ("X " + GameManager.Instance.numAxeT3).ToString();
        numSpearT1.text = ("X " + GameManager.Instance.numSpearT1).ToString();
        numSpearT2.text = ("X " + GameManager.Instance.numSpearT2).ToString();
        numSpearT3.text = ("X " + GameManager.Instance.numSpearT3).ToString();

        numClothT1.text = ("X " + GameManager.Instance.numClothT1).ToString();
        numClothT2.text = ("X " + GameManager.Instance.numClothT2).ToString();
        numClothT3.text = ("X " + GameManager.Instance.numClothT3).ToString();
        numLeatherT1.text = ("X " + GameManager.Instance.numLeatherT1).ToString();
        numLeatherT2.text = ("X " + GameManager.Instance.numLeatherT2).ToString();
        numLeatherT3.text = ("X " + GameManager.Instance.numLeatherT3).ToString();
        numPlateT1.text = ("X " + GameManager.Instance.numPlateT1).ToString();
        numPlateT2.text = ("X " + GameManager.Instance.numPlateT2).ToString();
        numPlateT3.text = ("X " + GameManager.Instance.numPlateT3).ToString();

        numHealingT1.text = ("X " + GameManager.Instance.numHealingT1).ToString();
        numHealingT2.text = ("X " + GameManager.Instance.numHealingT2).ToString();
        numHealingT3.text = ("X " + GameManager.Instance.numHealingT3).ToString();


    }

    public void calculateTotalCards()
    {
        totalOffensiveCards = GameManager.Instance.addSwordT1 + GameManager.Instance.addSwordT2 + GameManager.Instance.addSwordT3 + GameManager.Instance.addAxeT1 + GameManager.Instance.addAxeT2 + GameManager.Instance.addAxeT3 + GameManager.Instance.addSpearT1 + GameManager.Instance.addSpearT2 + GameManager.Instance.addSpearT3;
        totalDefensiveCards = GameManager.Instance.addClothT1 + GameManager.Instance.addClothT2 + GameManager.Instance.addClothT3 + GameManager.Instance.addLeatherT1 + GameManager.Instance.addLeatherT2 + GameManager.Instance.addLeatherT3 + GameManager.Instance.addPlateT1 + GameManager.Instance.addPlateT2 + GameManager.Instance.addPlateT3;
        totalConsumableCards = GameManager.Instance.addHealingT1 + GameManager.Instance.addHealingT2 + GameManager.Instance.addHealingT3;
    }
}
