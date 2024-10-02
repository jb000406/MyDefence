using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyDefence
{

    public class MainMenuUI : MonoBehaviour
    {
        #region Variables
        public SceneFader fader;
        [SerializeField] private string loadToScene = "PlayScene";

        #endregion
        public void PlayButton()
        {
            Debug.Log("Goto PlaySence");
            fader.FadeTo(loadToScene);
        }

        public void QuitButton()
        {
            Debug.Log("Game Quit");
            Application.Quit();
        }

    }
}