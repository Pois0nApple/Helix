using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public AudioClip audioClip;
    [Min(0)]
    public float Vol;
    private AudioSource _audio;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "sector")
        {
            _audio.PlayOneShot(audioClip, Vol);
        }
        if (collision.collider.name == "sector (1)")
        {
            _audio.PlayOneShot(audioClip, Vol);
        }
        if (collision.collider.name == "sector (2)")
        {
            _audio.PlayOneShot(audioClip, Vol);
        }
        if (collision.collider.name == "sector (3)")
        {
            _audio.PlayOneShot(audioClip, Vol);
        }

    }
}
