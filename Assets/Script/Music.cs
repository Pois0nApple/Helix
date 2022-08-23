using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip Audio;
    [Min(0)]
    public float Vol;
    private AudioSource _audio;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }


    private void OnEnable()
    {
       
        {
            _audio.PlayOneShot(Audio, Vol);
        }

    }
}
