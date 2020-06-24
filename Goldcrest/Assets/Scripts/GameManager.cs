﻿using System.Collections;
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

    public int totalCoins;
    public int coinsCollected;

    //Level scores
    public int currentScore;
    public int level1Score;

    // Player stats

    public int playerHealth;
    public int weaponDamage;
    public int weaponRange;
    public float attackCooldown;
    public float moveSpeed = 5f;
    public int dodgeForce = 1000;

    //Movement
    public bool isMoving = false;
    //public bool isDodging = false;


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

}