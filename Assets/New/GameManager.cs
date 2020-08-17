using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerHighScore = 0;
    public int playerCurrentScore = 0;

    public string playersName = "DefaultJohn";

    public float gameTimer = 5f;
    public bool isGameOver = false;

    public static string PLAYERNAMESAVE = "PLayerName";

    // Start is called before the first frame update
    void Start()
    {
        playerHighScore = PlayerPrefs.GetInt("HighScore");
        playersName = PlayerPrefs.GetString(PLAYERNAMESAVE);

        print("Current High Score: " + playerHighScore);
        print("Players name: " + playersName);
    }

    public void UpdatePlayerScore()
    {

    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
