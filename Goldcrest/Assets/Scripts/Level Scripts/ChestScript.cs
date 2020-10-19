using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestScript : MonoBehaviour
{

    private float maxChestHealth = 75f;
    private float currentChestHealth;

    public Image chestHealthbar;

    public GameObject closedChest;
    public GameObject openChest;


    // Start is called before the first frame update
    void Start()
    {
        currentChestHealth = maxChestHealth;
    }

    public void TakeDamage(int damage)
    {
        currentChestHealth -= damage;
        chestHealthbar.fillAmount = currentChestHealth / maxChestHealth;

        // play animation

        if (currentChestHealth <= 0)
        {
            Open();
        }
    }

    void Open()
    {
        closedChest.SetActive(false);
        openChest.SetActive(true);
    }
}
