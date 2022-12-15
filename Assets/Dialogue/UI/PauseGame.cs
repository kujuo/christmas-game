using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject PauseUI;
    GameObject pauseUIDisplay;
    public void Pause()
    {
        Time.timeScale = 0;
        pauseUIDisplay = Instantiate(PauseUI);
        pauseUIDisplay.SetActive(true);
    }

    public void Resume()
    {
        Destroy(pauseUIDisplay);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MenuMain");
        //Application.Quit();
    }
}

