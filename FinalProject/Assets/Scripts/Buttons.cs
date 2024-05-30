using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
      public void PlayGame()
   {
        SceneManager.LoadSceneAsync(2);
   }

      public void AboutScreen()
   {
        SceneManager.LoadSceneAsync(1);
   }

      public void MainMenuScreen()
   {
        SceneManager.LoadSceneAsync(0);
   }
}