using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseScreen;
    public float timeRemaining = 60;
    public GameObject aboutScreen;
    private bool paused;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            ChangePause();
        }

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else{
                    SceneManager.LoadSceneAsync(3);
        }
    }

    void ChangePause()
    {
        if (!paused)
        {
            paused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            paused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
