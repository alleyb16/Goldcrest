using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loadout : MonoBehaviour
{
    public GearSwap gear;

    public Text HealthScore;
    public Text MoveSpeedScore;
    public Text KnockbackScore;
    public Text AttackSpeedScore;
    public Text AgilityScore;

    public Button offensiveImage;
    public Button defensiveImage;
    public Button consumableImage;

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


    // Covers for locked cards
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

    // Borders for Equipped cards
    public Image SwordT1Border;
    public Image SwordT2Border;
    public Image SwordT3Border;
    public Image AxeT1Border;
    public Image AxeT2Border;
    public Image AxeT3Border;
    public Image SpearT1Border;
    public Image SpearT2Border;
    public Image SpearT3Border;

    public Image ClothT1Border;
    public Image ClothT2Border;
    public Image ClothT3Border;
    public Image LeatherT1Border;
    public Image LeatherT2Border;
    public Image LeatherT3Border;
    public Image PlateT1Border;
    public Image PlateT2Border;
    public Image PlateT3Border;

    public Image HealingT1Border;
    public Image HealingT2Border;
    public Image HealingT3Border;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        updateCardImage();
        CalculateStats();
        revealCards();
        ShowCardBorder();
        gear.equipGear();
    }

    // Edits player's stats page based on cards equipped
    public void CalculateStats()
    {
        HealthScore.text = GameManager.Instance.playerMaxHealth.ToString();
        MoveSpeedScore.text = (GameManager.Instance.moveSpeed * 10).ToString();
        KnockbackScore.text = GameManager.Instance.weaponKnockback.ToString();
        AttackSpeedScore.text = GameManager.Instance.attackCooldown.ToString();
        AgilityScore.text = (GameManager.Instance.dodgeForce / 5).ToString();
    }

    // Edits the card image to display currently equipped cards
    public void updateCardImage()
    {
        // Offensive Cards
        // Update Sword Images
        if (GameManager.Instance.SwordT1)
        {
            offensiveImage.GetComponent<Image>().sprite = ImgSwordT1;
        }
        if (GameManager.Instance.SwordT2)
        {
            offensiveImage.GetComponent<Image>().sprite = ImgSwordT2;
        }
        if (GameManager.Instance.SwordT3)
        {
            offensiveImage.GetComponent<Image>().sprite = ImgSwordT3;
        }

        // Update Axe Images
        if (GameManager.Instance.AxeT1)
        {
            offensiveImage.GetComponent<Image>().sprite = ImgAxeT1;
        }
        if (GameManager.Instance.AxeT2)
        {
            offensiveImage.GetComponent<Image>().sprite = ImgAxeT2;
        }
        if (GameManager.Instance.AxeT3)
        {
            offensiveImage.GetComponent<Image>().sprite = ImgAxeT3;
        }

        // Update Spear Images
        if (GameManager.Instance.SpearT1)
        {
            offensiveImage.GetComponent<Image>().sprite = ImgSpearT1;
        }
        if (GameManager.Instance.SpearT2)
        {
            offensiveImage.GetComponent<Image>().sprite = ImgSpearT2;
        }
        if (GameManager.Instance.SpearT3)
        {
            offensiveImage.GetComponent<Image>().sprite = ImgSpearT3;
        }


        // Defensive Cards
        // Updates Cloth Images
        if (GameManager.Instance.ClothT1)
        {
            defensiveImage.GetComponent<Image>().sprite = ImgClothT1;
        }
        if (GameManager.Instance.ClothT2)
        {
            defensiveImage.GetComponent<Image>().sprite = ImgClothT2;
        }
        if (GameManager.Instance.ClothT3)
        {
            defensiveImage.GetComponent<Image>().sprite = ImgClothT3;
        }

        // Updates Leather Images
        if (GameManager.Instance.LeatherT1)
        {
            defensiveImage.GetComponent<Image>().sprite = ImgLeatherT1;
        }
        if (GameManager.Instance.LeatherT2)
        {
            defensiveImage.GetComponent<Image>().sprite = ImgLeatherT2;
        }
        if (GameManager.Instance.LeatherT3)
        {
            defensiveImage.GetComponent<Image>().sprite = ImgLeatherT3;
        }

        // Updates Plate Images
        if (GameManager.Instance.PlateT1)
        {
            defensiveImage.GetComponent<Image>().sprite = ImgPlateT1;
        }
        if (GameManager.Instance.PlateT2)
        {
            defensiveImage.GetComponent<Image>().sprite = ImgPlateT2;
        }
        if (GameManager.Instance.PlateT3)
        {
            defensiveImage.GetComponent<Image>().sprite = ImgPlateT3;
        }

        // Updates Healing Potion Images
        if (GameManager.Instance.HealingT1)
        {
            consumableImage.GetComponent<Image>().sprite = ImgHealingT1;
        }
        if (GameManager.Instance.HealingT2)
        {
            consumableImage.GetComponent<Image>().sprite = ImgHealingT2;
        }
        if (GameManager.Instance.HealingT3)
        {
            consumableImage.GetComponent<Image>().sprite = ImgHealingT3;

        }
    }

    // Lock/unlock card covers
    public void revealCards()
    {
        // Offensive Card Covers
        if (GameManager.Instance.hasSwordT1) // Show SwordT1 if owned
        {
            SwordT1Cover.enabled = false;
        }
        else 
        {
            SwordT1Cover.enabled = true; // Hide SwordT2 if not owned
        }

        if (GameManager.Instance.hasSwordT2) // Show SwordT2
        {
            SwordT2Cover.enabled = false;
        }
        else
        {
            SwordT2Cover.enabled = true; // Hide SwordT2
        }

        if (GameManager.Instance.hasSwordT3) // Show SwordT3
        {
            SwordT3Cover.enabled = false;
        }
        else
        {
            SwordT3Cover.enabled = true; // Hide SwordT3
        }

        if (GameManager.Instance.hasAxeT1) // Show AxeT1
        {
            AxeT1Cover.enabled = false;
        }
        else
        {
            AxeT1Cover.enabled = true; // Hide AxeT1
        }

        if (GameManager.Instance.hasAxeT2) // Show AxeT2
        {
            AxeT2Cover.enabled = false;
        }
        else
        {
            AxeT2Cover.enabled = true; // Hide AxeT2
        }

        if (GameManager.Instance.hasAxeT3) // Show AxeT3
        {
            AxeT3Cover.enabled = false; 
        }
        else
        {
            AxeT3Cover.enabled = true; // Hide AxeT3
        }

        if (GameManager.Instance.hasSpearT1) // Show SpearT1
        {
            SpearT1Cover.enabled = false;
        }
        else
        {
            SpearT1Cover.enabled = true; // Hide SpearT1
        }

        if (GameManager.Instance.hasSpearT2) // Show SpearT2
        {
            SpearT2Cover.enabled = false;
        }
        else
        {
            SpearT2Cover.enabled = true; // Hide SpearT2
        }

        if (GameManager.Instance.hasSpearT3) // Show SpearT3
        {
            SpearT3Cover.enabled = false;
        }
        else
        {
            SpearT3Cover.enabled = true; // Hide SpearT3
        }

        // Defensive Card Covers
        if (GameManager.Instance.hasClothT1) // Show ClothT1 if owned
        {
            ClothT1Cover.enabled = false;
        }
        else
        {
            ClothT1Cover.enabled = true; // Hide ClothT1 if not owned
        }

        if (GameManager.Instance.hasClothT2) // Show ClothT2
        {
            ClothT2Cover.enabled = false;
        }
        else
        {
            ClothT2Cover.enabled = true; // Hide ClothT2
        }

        if (GameManager.Instance.hasClothT3) // Show ClothT3
        {
            ClothT3Cover.enabled = false;
        }
        else
        {
            ClothT3Cover.enabled = true; // Hide ClothT3
        }

        if (GameManager.Instance.hasLeatherT1) // Show LeatherT1
        {
            LeatherT1Cover.enabled = false;
        }
        else
        {
            LeatherT1Cover.enabled = true; // Hide LeatherT1
        }

        if (GameManager.Instance.hasLeatherT2) // Show LeatherT2
        {
            LeatherT2Cover.enabled = false;
        }
        else
        {
            LeatherT2Cover.enabled = true; // Hide LeatherT2
        }

        if (GameManager.Instance.hasLeatherT3) // Show LeatherT3
        {
            LeatherT3Cover.enabled = false;
        }
        else
        {
            LeatherT3Cover.enabled = true; // Hide LeatherT3
        }

        if (GameManager.Instance.hasPlateT1) // Show PlateT1
        {
            PlateT1Cover.enabled = false;
        }
        else
        {
            PlateT1Cover.enabled = true; // Hide PlateT1
        }

        if (GameManager.Instance.hasPlateT2) // Show PlateT2
        {
            PlateT2Cover.enabled = false;
        }
        else
        {
            PlateT2Cover.enabled = true; // Hide PlateT2
        }

        if (GameManager.Instance.hasPlateT3) // Show PlateT3
        {
            PlateT3Cover.enabled = false;
        }
        else
        {
            PlateT3Cover.enabled = true; // Hide PlateT3
        }

        // Consumable Card Covers
        if (GameManager.Instance.hasHealingT1)
        {
            HealingT1Cover.enabled = false;
        }
        else
        {
            HealingT1Cover.enabled = true;
        }

        if (GameManager.Instance.hasHealingT2)
        {
            HealingT2Cover.enabled = false;
        }
        else
        {
            HealingT2Cover.enabled = true;
        }

        if (GameManager.Instance.hasHealingT3)
        {
            HealingT3Cover.enabled = false;
        }
        else
        {
            HealingT3Cover.enabled = true;
        }
    }

    public void ShowCardBorder()
    {
        // Offensive Borders
        if (GameManager.Instance.SwordT1)
        {
            SwordT1Border.enabled = true;
            SwordT2Border.enabled = false;
            SwordT3Border.enabled = false;
            AxeT1Border.enabled = false;
            AxeT2Border.enabled = false;
            AxeT3Border.enabled = false;
            SpearT1Border.enabled = false;
            SpearT2Border.enabled = false;
            SpearT3Border.enabled = false;
        }
        if (GameManager.Instance.SwordT2)
        {
            SwordT1Border.enabled = false;
            SwordT2Border.enabled = true;
            SwordT3Border.enabled = false;
            AxeT1Border.enabled = false;
            AxeT2Border.enabled = false;
            AxeT3Border.enabled = false;
            SpearT1Border.enabled = false;
            SpearT2Border.enabled = false;
            SpearT3Border.enabled = false;
        }
        if (GameManager.Instance.SwordT3)
        {
            SwordT1Border.enabled = false;
            SwordT2Border.enabled = false;
            SwordT3Border.enabled = true;
            AxeT1Border.enabled = false;
            AxeT2Border.enabled = false;
            AxeT3Border.enabled = false;
            SpearT1Border.enabled = false;
            SpearT2Border.enabled = false;
            SpearT3Border.enabled = false;
        }
        if (GameManager.Instance.AxeT1)
        {
            SwordT1Border.enabled = false;
            SwordT2Border.enabled = false;
            SwordT3Border.enabled = false;
            AxeT1Border.enabled = true;
            AxeT2Border.enabled = false;
            AxeT3Border.enabled = false;
            SpearT1Border.enabled = false;
            SpearT2Border.enabled = false;
            SpearT3Border.enabled = false;
        }
        if (GameManager.Instance.AxeT2)
        {
            SwordT1Border.enabled = false;
            SwordT2Border.enabled = false;
            SwordT3Border.enabled = false;
            AxeT1Border.enabled = false;
            AxeT2Border.enabled = true;
            AxeT3Border.enabled = false;
            SpearT1Border.enabled = false;
            SpearT2Border.enabled = false;
            SpearT3Border.enabled = false;
        }
        if (GameManager.Instance.AxeT3)
        {
            SwordT1Border.enabled = false;
            SwordT2Border.enabled = false;
            SwordT3Border.enabled = false;
            AxeT1Border.enabled = false;
            AxeT2Border.enabled = false;
            AxeT3Border.enabled = true;
            SpearT1Border.enabled = false;
            SpearT2Border.enabled = false;
            SpearT3Border.enabled = false;
        }
        if (GameManager.Instance.SpearT1)
        {
            SwordT1Border.enabled = false;
            SwordT2Border.enabled = false;
            SwordT3Border.enabled = false;
            AxeT1Border.enabled = false;
            AxeT2Border.enabled = false;
            AxeT3Border.enabled = false;
            SpearT1Border.enabled = true;
            SpearT2Border.enabled = false;
            SpearT3Border.enabled = false;
        }
        if (GameManager.Instance.SpearT2)
        {
            SwordT1Border.enabled = false;
            SwordT2Border.enabled = false;
            SwordT3Border.enabled = false;
            AxeT1Border.enabled = false;
            AxeT2Border.enabled = false;
            AxeT3Border.enabled = false;
            SpearT1Border.enabled = false;
            SpearT2Border.enabled = true;
            SpearT3Border.enabled = false;
        }
        if (GameManager.Instance.SpearT3)
        {
            SwordT1Border.enabled = false;
            SwordT2Border.enabled = false;
            SwordT3Border.enabled = false;
            AxeT1Border.enabled = false;
            AxeT2Border.enabled = false;
            AxeT3Border.enabled = false;
            SpearT1Border.enabled = false;
            SpearT2Border.enabled = false;
            SpearT3Border.enabled = true;
        }

        // Defensive Borders
        if (GameManager.Instance.ClothT1)
        {
            ClothT1Border.enabled = true;
            ClothT2Border.enabled = false;
            ClothT3Border.enabled = false;
            LeatherT1Border.enabled = false;
            LeatherT2Border.enabled = false;
            LeatherT3Border.enabled = false;
            PlateT1Border.enabled = false;
            PlateT2Border.enabled = false;
            PlateT3Border.enabled = false;
        }
        if (GameManager.Instance.ClothT2)
        {
            ClothT1Border.enabled = false;
            ClothT2Border.enabled = true;
            ClothT3Border.enabled = false;
            LeatherT1Border.enabled = false;
            LeatherT2Border.enabled = false;
            LeatherT3Border.enabled = false;
            PlateT1Border.enabled = false;
            PlateT2Border.enabled = false;
            PlateT3Border.enabled = false;
        }
        if (GameManager.Instance.ClothT3)
        {
            ClothT1Border.enabled = false;
            ClothT2Border.enabled = false;
            ClothT3Border.enabled = true;
            LeatherT1Border.enabled = false;
            LeatherT2Border.enabled = false;
            LeatherT3Border.enabled = false;
            PlateT1Border.enabled = false;
            PlateT2Border.enabled = false;
            PlateT3Border.enabled = false;
        }
        if (GameManager.Instance.LeatherT1)
        {
            ClothT1Border.enabled = false;
            ClothT2Border.enabled = false;
            ClothT3Border.enabled = false;
            LeatherT1Border.enabled = true;
            LeatherT2Border.enabled = false;
            LeatherT3Border.enabled = false;
            PlateT1Border.enabled = false;
            PlateT2Border.enabled = false;
            PlateT3Border.enabled = false;
        }
        if (GameManager.Instance.LeatherT2)
        {
            ClothT1Border.enabled = false;
            ClothT2Border.enabled = false;
            ClothT3Border.enabled = false;
            LeatherT1Border.enabled = false;
            LeatherT2Border.enabled = true;
            LeatherT3Border.enabled = false;
            PlateT1Border.enabled = false;
            PlateT2Border.enabled = false;
            PlateT3Border.enabled = false;
        }
        if (GameManager.Instance.LeatherT3)
        {
            ClothT1Border.enabled = false;
            ClothT2Border.enabled = false;
            ClothT3Border.enabled = false;
            LeatherT1Border.enabled = false;
            LeatherT2Border.enabled = false;
            LeatherT3Border.enabled = true;
            PlateT1Border.enabled = false;
            PlateT2Border.enabled = false;
            PlateT3Border.enabled = false;
        }
        if (GameManager.Instance.PlateT1)
        {
            ClothT1Border.enabled = false;
            ClothT2Border.enabled = false;
            ClothT3Border.enabled = false;
            LeatherT1Border.enabled = false;
            LeatherT2Border.enabled = false;
            LeatherT3Border.enabled = false;
            PlateT1Border.enabled = true;
            PlateT2Border.enabled = false;
            PlateT3Border.enabled = false;
        }
        if (GameManager.Instance.PlateT2)
        {
            ClothT1Border.enabled = false;
            ClothT2Border.enabled = false;
            ClothT3Border.enabled = false;
            LeatherT1Border.enabled = false;
            LeatherT2Border.enabled = false;
            LeatherT3Border.enabled = false;
            PlateT1Border.enabled = false;
            PlateT2Border.enabled = true;
            PlateT3Border.enabled = false;
        }
        if (GameManager.Instance.PlateT3)
        {
            ClothT1Border.enabled = false;
            ClothT2Border.enabled = false;
            ClothT3Border.enabled = false;
            LeatherT1Border.enabled = false;
            LeatherT2Border.enabled = false;
            LeatherT3Border.enabled = false;
            PlateT1Border.enabled = false;
            PlateT2Border.enabled = false;
            PlateT3Border.enabled = true;
        }

        // Consumable Borders
        if (GameManager.Instance.HealingT1)
        {
            HealingT1Border.enabled = true;
            HealingT2Border.enabled = false;
            HealingT3Border.enabled = false;
        }
        if (GameManager.Instance.HealingT2)
        {
            HealingT1Border.enabled = false;
            HealingT2Border.enabled = true;
            HealingT3Border.enabled = false;
        }
        if (GameManager.Instance.HealingT3)
        {
            HealingT1Border.enabled = false;
            HealingT2Border.enabled = false;
            HealingT3Border.enabled = true;
        }
    }

}
