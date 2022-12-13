using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaughterLetterUI : Action
{
    public GameObject DaughterLetterGraphic;
    public override void DoAction()
    {
        GameObject daughterLetter = Instantiate(DaughterLetterGraphic);
        daughterLetter.SetActive(true);
    }
}
