using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    public int currentScore = 0;                                            // declaring and setting a score int so it starts at 0 everytime the game is played   
    public string startScore = "N/A";                                       // declaring and setting a string variable to display before player recieves any points
    public string currentScoreString;                                       // declaring a string variable for later assignment
    private int highScore;                                                  // declaring an int variable for later use and assignment
    Text scoreUI;                                                           // declaring a text gameobject for later use and assignment

    void Start()
    {
        scoreUI = gameObject.GetComponent<Text>();                          // assigning the previously declared "scoreUI" to the parent gameobject's text component
        PlayerPrefs.SetString("currentScore", startScore);                  // setting the startScore to a string playerprefs on startup so it can be displayed on-screen to player and is automatically nothing on the game's start
    }

    void Update()
    {
        scoreUI.text = PlayerPrefs.GetString("currentScore");               // assigning the text component of gameobject "scoreUI" to the playerprefs current score for UI display
        highScore = PlayerPrefs.GetInt("highScore");                        // setting the previously (if existing) saved highscore to a new variable for easy local use

        if (currentScore > highScore)                                       // if value "currentScore" surpasses that of "highScore"...
        {
            PlayerPrefs.SetInt("highScore", currentScore);                  // update the "highScore" playerpref to adopt the value of the current highscore
        }
    }

    public void scoreAddition()                                             // function called by "ScoreUpdater" script
    {
        currentScore = currentScore + 1;                                    // add 1 to score each time called
        currentScoreString = currentScore.ToString();                       // converts currentScore to string for currentScoreString...
        PlayerPrefs.SetString("currentScore", currentScoreString);          // sets currentScoreString to a playerpref so it can be displayed in a textbox on-screen during gameplay
    }
}
