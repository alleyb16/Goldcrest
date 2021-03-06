﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{

    private float maxDoorHealth = 50f;
    private float currentDoorHealth;

    public Image doorHealthbar;


    // Start is called before the first frame update
    void Start()
    {
        currentDoorHealth = maxDoorHealth;
    }

    public void TakeDamage(int damage)
    {
        currentDoorHealth -= damage;
        doorHealthbar.fillAmount = currentDoorHealth / maxDoorHealth;

        // play animation

        if (currentDoorHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GetComponent<BoxCollider>().enabled = false;
        FindObjectOfType<AudioManager>().Play("ObstacleDestroyed"); // Play attack sound

        Destroy(gameObject, 1);
    }
}
