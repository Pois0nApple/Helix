using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour

{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Gamer gamer))
        {
            gamer.CurrentPlatform = this;
        }
    }
}
