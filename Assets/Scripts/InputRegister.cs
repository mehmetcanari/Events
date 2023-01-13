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
        OnClick();
    }

    private void OnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
           _actionListener.Invoke();
        }
    }
}
