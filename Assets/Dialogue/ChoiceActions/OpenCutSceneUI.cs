using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCutSceneUI : Action
{
    public GameObject OpenCutsceneUIGraphic;
    public override void DoAction()
    {
        GameObject daughterLetter = Instantiate(OpenCutsceneUIGraphic);
        daughterLetter.SetActive(true);
    }
}
