
using System;
using UnityEngine;

public class Gamer : MonoBehaviour
{
   public float Speed;
   public Rigidbody Rigidbody;
   public Game Game;

  public Platform CurrentPlatform;

   public void Bounce()
    {
      Rigidbody.velocity = new Vector3(0,Speed,0);
    }

    public void ReachFinish()
    {
        Game.OnPlayerReachFinish();
        Rigidbody.velocity =  Vector3.zero;
    }

    public void Die()
    {
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
    }
}
