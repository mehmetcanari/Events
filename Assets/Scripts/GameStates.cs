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


    public void ChangeState(States _desiredState)
    {
        _gameStates = _desiredState;
    }
}

public enum States
{
    IsClosed,
    IsOpened
}
