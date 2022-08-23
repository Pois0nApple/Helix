
using UnityEngine;

public class Finsh : MonoBehaviour
{
    private void  OnCollisionEnter (Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Gamer gamer)) return;
        gamer.ReachFinish();
    }
}
    