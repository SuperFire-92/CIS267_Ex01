using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//Attached to Player
public class PlayerScore : MonoBehaviour
{
    private int playerScore;
    public TMP_Text guiScore;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
    }

    public int getScore()
    {
        return playerScore;
    }
    
    public void setPlayerScore(int val)
    {
        playerScore += val;
        guiScore.text = "Score: " + playerScore.ToString();
        Debug.Log("Current Score: " + playerScore);
    }
}
