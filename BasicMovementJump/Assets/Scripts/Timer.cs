using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float time;
    private TMP_Text guiTime;
    // Start is called before the first frame update
    void Start()
    {
        time = 20;
        guiTime = GetComponent<TMP_Text>();
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
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void updateGUITime()
    {
        guiTime.text = "Time: " + time;
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
