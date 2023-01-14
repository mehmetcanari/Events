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
        if (GameStates.Instance._gameStates == States.IsClosed)
        {
            _doorHandle.DORotate(new Vector3(0, 0, -45f), _interactSpeed).SetEase(_easing).OnComplete(() =>
            {
                _doorHandle.DORotate(Vector3.zero, _interactSpeed).SetEase(_easing);

                _door.DORotate(new Vector3(0, -45f, 0), _interactSpeed).SetEase(_easing).OnComplete(() =>
                {
                    GameStates.Instance.ChangeState(States.IsOpened);
                });
            });
        }
    }


    public void Close()
    {
        if (GameStates.Instance._gameStates == States.IsOpened)
        {
            _doorHandle.DORotate(new Vector3(0, 0, -45f), _interactSpeed).SetEase(_easing).OnComplete(() =>
            {
                _doorHandle.DORotate(Vector3.zero, _interactSpeed).SetEase(_easing);

                _door.DORotate(Vector3.zero, _interactSpeed).SetEase(_easing).OnComplete(() =>
                {
                    GameStates.Instance.ChangeState(States.IsClosed);
                });
            });
        }
    }
}
