using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameManager control;

    public enum State
    {
        InMenu,
        InOptions,
        InGameplay,
        InPause,
        InWinScreen,
        InLoseScreen,
        InCredits
    }

    public State currentState;
    public State previousState;

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (currentState)
        {
            case State.InMenu:

                break;

            case State.InOptions:

                break;

            case State.InGameplay:

                break;

            case State.InPause:

                break;

            case State.InWinScreen:

                break;

            case State.InLoseScreen:

                break;

            case State.InCredits:

                break;
        } 
    }

    void SwitchState(State state)
    {
        previousState = currentState;
        currentState = state;
    }
}
