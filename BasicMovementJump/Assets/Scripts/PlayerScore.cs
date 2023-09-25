using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//Attached to Player
public class PlayerScore : MonoBehaviour
{
    private int playerScore;
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
        Debug.Log("Current Score: " + playerScore);
    }
}
