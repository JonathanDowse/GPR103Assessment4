﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveandLoad : MonoBehaviour
{


    public int playerHighScore = 0;
    public int playerCurrentScore = 0;

    public string playersName = "DefaultName";

    public float gameTimer = 5f;
    public bool isGameOver = false;

    public static string PLAYERNAMESAVE = "PlayerName";

    // Start is called before the first frame update
    void Start()
    {
        playerHighScore = PlayerPrefs.GetInt("HighScore");
        playersName = PlayerPrefs.GetString(PLAYERNAMESAVE);
        print("Current High Score: " + playerHighScore);
        print("Players Name: " + playersName);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {
            playersName = "BingBong";
            PlayerPrefs.SetString(PLAYERNAMESAVE, playersName);
        }


        if(Input.GetKeyDown(KeyCode.Delete))
        {
            PlayerPrefs.DeleteAll();
        }

        if(Input.GetKeyDown(KeyCode.Space) && isGameOver != true)
        {
            playerCurrentScore += 1;
        }

        gameTimer -= Time.deltaTime;
        if (gameTimer <= 0 && isGameOver != true)
        {
            isGameOver = true;
            if(playerCurrentScore > playerHighScore)
            {
                playerHighScore = playerCurrentScore;
                PlayerPrefs.SetInt("HighScore", playerHighScore);
            }
            //Game Over
        }
    }
}
