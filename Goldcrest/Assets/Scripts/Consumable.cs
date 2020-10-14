using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : MonoBehaviour
{
    public void UsePotion()
    {
        GameManager.Instance.playerHealth += 50f;
        print("used Potion");
    }

}
