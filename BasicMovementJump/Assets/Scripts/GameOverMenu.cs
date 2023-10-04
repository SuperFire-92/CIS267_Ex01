using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    //Drag and drop connection through Unity
    public GameObject gameManager;
    //Initialized via GetComponent<>()
    private GameManager gm;

    public GameObject gameOverMenu;

    private void Start()
    {
        gm = gameManager.GetComponent<GameManager>();
    }

    private void Update()
    {
        if(gm.getGameOver() == true)
        {
            showGameOverMenu();
        }
    }

    public void showGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void restartGame()
    {
        gm.setGameOver(false);
        gameOverMenu.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }
}
