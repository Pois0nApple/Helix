
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Ctrl Ctrl;

   
    public enum State
    {
        Playng,
        Won,
        Loss,
    }
    public State CurrentState { get; private set;  }
    public void OnPlayerDied()
    {
        if (CurrentState != State.Playng) return;

        CurrentState = State.Loss;
        Ctrl.enabled = false;
        Debug.Log("Упс! ");
        ReloadLvl();
    }

    public void OnPlayerReachFinish()
    {
        if (CurrentState != State.Playng) return;

        CurrentState= State.Won;
        Ctrl.enabled = false;
        LvlIndex++;
        Debug.Log("Победа! ");
        ReloadLvl();
    }

    public int LvlIndex
    {
        get => PlayerPrefs.GetInt(LevelIndexKey, 0);
        private set
        {
            PlayerPrefs.SetInt(LevelIndexKey, value );
            PlayerPrefs.Save();
        }
    }
    private const string LevelIndexKey = "LevelIndex";
    private void ReloadLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
