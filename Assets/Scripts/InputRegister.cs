using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class InputRegister : MonoBehaviour
{
    public UnityEvent _actionListener;

    private void Update()
    {
        switch (GameStates.Instance._gameStates)
        {
            case States.Play:
                OnClick();
                break;
        }
    }

    private void OnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
           _actionListener.Invoke();
        }
    }
}
