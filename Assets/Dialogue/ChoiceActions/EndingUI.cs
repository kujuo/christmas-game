using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingUI : Action
{
    public GameObject EndingGraphic;
    public override void DoAction()
    {
        GameObject ending = Instantiate(EndingGraphic);
        ending.SetActive(true);
    }
}
