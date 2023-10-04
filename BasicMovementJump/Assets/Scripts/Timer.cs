using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time;
    private TMP_Text guiTime;

    //Assigned via Unity Editor
    public GameObject gameManager;
    //Assigned via GetComponent<GameManager>()
    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = gameManager.GetComponent<GameManager>();
        guiTime = GetComponent<TMP_Text>();
        updateGUITime();
    }
    

    // Update is called once per frame
    void Update()
    {
        timerTick();
    }

    public void timerTick()
    {
        time -= Time.deltaTime;

        updateGUITime();
        if (timeUp())
        {
            gm.setGameOver(true);

        }
    }

    public void updateGUITime()
    {
        guiTime.text = "Time: " + (int) (time + 1);
    }

    public bool timeUp()
    {
        if (time <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
