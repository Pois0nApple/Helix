using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public AudioClip Audio;
    [Min(0)]
    public float Vol;
    private AudioSource _audio;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Gamer")
        {
           _audio.PlayOneShot(Audio, Vol);
        }
       
    }
}
