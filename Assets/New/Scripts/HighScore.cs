using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public GameObject highscore;                                                        // declaring a new public gameobject that can have an existing gameobject assigned to it within unity
    public Text highScore;                                                              // declaring a new public text gameobject that can have an existing gameobject assigned to it and utilise the text component
    public string highScoreString;                                                      // declaring a string variable for later use and assignment
    public int currentHighScore;                                                        // declaring an int variable for later use and assignment

    void Update()
    {
        currentHighScore = PlayerPrefs.GetInt("highScore");                             // assigning the saved "highScore" playerpref to the "currentHighScore" int
        highScoreString = currentHighScore.ToString();                                  // assigning the string conversion value of "currentHighScore" to "highScoreString"
        highscore.GetComponent<UnityEngine.UI.Text>().text = highScoreString;           // accessing the text component of the attached "highscore" gameobject and applying the "highScoreString" value to it for player display
    }
}
