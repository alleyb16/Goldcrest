using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Consumable : MonoBehaviour
{
    private int charges;
    private float cooldownTimer;
    private float consumableCooldown;
    public bool consumableReady = true;
    private float cooldownPercent;
    public Image cooldown;

    public Text chargesTxt;

    private float drinkTimer;
    private float drinkTime = 1f;

    void Start()
    {
        charges = GameManager.Instance.consumableCharges;
        cooldown = GameObject.Find("consumableCooldown").GetComponent<Image>();

        consumableCooldown = GameManager.Instance.consumableCooldown;
    }

    void Update()
    {
        print(consumableReady);
        print("Cooldown Percent : " + cooldownPercent);
        chargesTxt.text = (charges.ToString());
        if (!consumableReady)
        {
            updateCooldown(); // updates the current cooldown on potion

            cooldownTimer -= Time.deltaTime; // continues counting down the cooldown timer while consumable is cooling down
            if(cooldownTimer <= 0f)
            {
                consumableReady = true;
            }
        }
        if (charges <= 0)
        {
            cooldown.fillAmount = 1f; // set the filter over the consumable when all charges are used
        }
    }

    public void UsePotion()
    {
            if (charges > 0 && consumableReady)
            {
            print("Used Potion");
            GameManager.Instance.isDrinking = true;
                charges--;
                GameManager.Instance.playerHealth += GameManager.Instance.healingDone;
            cooldownTimer = GameManager.Instance.consumableCooldown;
            consumableReady = false;
            drinkTimer = drinkTime;
            }
    }

    private void updateCooldown()
    {
        cooldownPercent = cooldownTimer / GameManager.Instance.consumableCooldown;
        //cooldownPercent = cooldownTimer / consumableCooldown;
        cooldown.fillAmount = cooldownPercent;

        if (GameManager.Instance.isDrinking)
        {
            drinkTimer -= Time.deltaTime;
            if(drinkTimer <= 0f)
            {
                GameManager.Instance.isDrinking = false;
            }
        }
    }
}
