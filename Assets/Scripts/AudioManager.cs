using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public void PlaySound(AudioSource _sound)
    {
        _sound.Play();
    }
}
