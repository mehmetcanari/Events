using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    public Transform _door;
    public Transform _doorHandle;
    public float _interactSpeed;
    public Ease _easing;

    public UnityEvent _doorActions;

    public void Open()
    {
        _doorHandle.DORotate(new Vector3(0, 0, -45f), _interactSpeed).SetEase(_easing).OnComplete(() =>
        {
            _door.DORotate(new Vector3(0, -45f, 0), _interactSpeed).SetEase(_easing);
        });
    }
}
