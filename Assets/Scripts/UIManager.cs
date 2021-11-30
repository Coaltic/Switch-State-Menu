using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameManager gameManager;

    public Canvas menu;
    public Canvas options;
    public Canvas gameplay;
    public Canvas pause;
    public Canvas win;
    public Canvas lose;
    public Canvas credits;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.currentState == GameManager.State.InMenu)
        {
            SwitchCanvas(menu);
        }
        if (gameManager.currentState == GameManager.State.InOptions)
        {
            SwitchCanvas(options);
        }
        if (gameManager.currentState == GameManager.State.InGameplay)
        {
            SwitchCanvas(gameplay);
        }
        if (gameManager.currentState == GameManager.State.InPause)
        {
            SwitchCanvas(pause);
        }
        if (gameManager.currentState == GameManager.State.InWinScreen)
        {
            SwitchCanvas(win);
        }
        if (gameManager.currentState == GameManager.State.InLoseScreen)
        {
            SwitchCanvas(lose);
        }
        if (gameManager.currentState == GameManager.State.InCredits)
        {
            SwitchCanvas(credits);
        }

    }

    void SwitchCanvas(Canvas canvas)
    {
        DisableAllCanvases();
        canvas.enabled = true;
    }

    void DisableAllCanvases()
    {
        menu.enabled = false;
        options.enabled = false;
        gameplay.enabled = false;
        pause.enabled = false;
        win.enabled = false;
        lose.enabled = false;
        credits.enabled = false;

    }

    void LoadMenu()
    {

    }
}
