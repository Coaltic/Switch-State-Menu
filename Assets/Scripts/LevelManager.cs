using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.currentState == GameManager.State.InGameplay)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                gameManager.SwitchState(GameManager.State.InWinScreen);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                gameManager.SwitchState(GameManager.State.InLoseScreen);
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                gameManager.SwitchState(GameManager.State.InPause);
            }
        }
    }

    public void OnClickPlayGame()
    {
        SceneManager.LoadScene(1);
        gameManager.SwitchState(GameManager.State.InGameplay);
    }

    public void OnClickMenu()
    {
        SceneManager.LoadScene(0);
        gameManager.SwitchState(GameManager.State.InMenu);
    }


    public void OnClickOptions()
    {
        gameManager.SwitchState(GameManager.State.InOptions);
    }


    public void OnClickBack()
    {
        gameManager.SwitchState(gameManager.previousState);
    }

    public void OnClickCredits()
    {
        gameManager.SwitchState(GameManager.State.InCredits);
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }
}
