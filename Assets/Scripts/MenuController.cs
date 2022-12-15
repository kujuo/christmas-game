using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuController : MonoBehaviour
{
    public void NewGame()
    {

        StartCoroutine(LoadNextLevel());
    }

    IEnumerator LoadNextLevel()
    {
        AsyncOperation loadLevel = SceneManager.LoadSceneAsync("Mother Scene");

        while (!loadLevel.isDone)
        {
            yield return null;
        }
    }
}
