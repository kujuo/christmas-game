using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterMother : Action
{
    public override void DoAction()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Diep environment");
    }
}
