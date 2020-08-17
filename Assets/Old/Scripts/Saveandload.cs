using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saveandload : MonoBehaviour
{
    public int playerHighScore = 0;
    public int playerCurrentScore = 0;

    public string playersName = "DefaultJohn";



    public static string PLAYERNAMESAVE = "PLayerName";

    // Start is called before the first frame update
    void Start()
    {
        playerHighScore = PlayerPrefs.GetInt("HighScore");
        playersName = PlayerPrefs.GetString(PLAYERNAMESAVE);

        print("Current High Score: " + playerHighScore);
        print("Players name: " + playersName);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {
            playersName = "Kazza";
            PlayerPrefs.SetString(PLAYERNAMESAVE, playersName);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            playersName = "Molly";
            PlayerPrefs.SetString(PLAYERNAMESAVE, playersName);
        }

        if(Input.GetKeyDown(KeyCode.Delete))
        {
           // PlayerPrefs.DeleteKey("HighScore");
            PlayerPrefs.DeleteAll();
        }

        //if (Input.GetKeyDown(KeyCode.Space) && isGameOver != true)
        //{
         //   playerCurrentScore += 1;
       // }

       
    }
}
