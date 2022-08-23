using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Gamer Gamer;
    public Vector3 CameraOffset;
    public float Speed;

    void Update()
    {
        if (Gamer.CurrentPlatform == null) return;
        
        Vector3 targetPosition = Gamer.CurrentPlatform.transform.position + CameraOffset;
        transform.position = Vector3.MoveTowards (transform.position, targetPosition, Speed*Time.deltaTime);
    }
}
