using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameManager gameManger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickPlayGame()
    {
        SceneManager.LoadScene(1);
        gameManger.currentState = GameManager.State.InGameplay;
    }

    public void OnClickOptions()
    {
        gameManger.currentState = GameManager.State.InOptions;
    }

    public void OnClickQuit()
    {
        gameManger.currentState = GameManager.State.InOptions;
    }
}
