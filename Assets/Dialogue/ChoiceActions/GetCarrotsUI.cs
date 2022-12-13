using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GetCarrotsUI : Action
{
    public GameObject carrotsUI;
    public override void DoAction()
    {
        carrotsUI.SetActive(true);
    }
}

