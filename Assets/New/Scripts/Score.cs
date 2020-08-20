using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    public int currentScore = 0;
    public string startScore = "N/A";
    public string currentScoreString;

    Text scoreUI;

    // Start is called before the first frame update
    void Start()
    {
        scoreUI = gameObject.GetComponent<Text>();
        PlayerPrefs.SetString("currentScore", startScore);
    }

    // Update is called once per frame
    void Update()
    {
        
        scoreUI.text = PlayerPrefs.GetString("currentScore");
        
    }

    public void scoreAddition()
    {
        currentScore = currentScore + 1;
        currentScoreString = currentScore.ToString();
        PlayerPrefs.SetString("currentScore", currentScoreString);

    }

    
}
