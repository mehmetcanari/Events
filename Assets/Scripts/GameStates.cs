using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStates : MonoBehaviour
{
    public static GameStates Instance;

    public States _gameStates;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    public void ChangeState(int _stateIndex)
    {
        switch (_stateIndex)
        {
            case 1:
                _gameStates = States.Play;
                break;

            case 0:
                _gameStates = States.Finish;
                break;
        }
    }
}

public enum States
{
    Play,
    Finish
}
