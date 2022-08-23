using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script
{
    public class LevelNumber : MonoBehaviour
    {
        public Text Text;
        public Game Game;

        private void Start ()
        {
            Text.text = "LeveL " + (Game.LvlIndex+1).ToString();      
        }
    }
}