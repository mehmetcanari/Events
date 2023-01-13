using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputActions : MonoBehaviour
{
    private string _doorHandleTag = "Handle";
    private RaycastHit hit;

    public void RegisterRaycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out hit, 100);
    }

    public void CheckHit()
    {
        if (!hit.transform.CompareTag(_doorHandleTag)) return;
        hit.transform.GetComponent<Door>()._doorActions.Invoke();
    }
}
