using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostmanMailUI : Action
{
    public GameObject postmanMailUI;
    public override void DoAction()
    {
        GameObject mailUI = Instantiate(postmanMailUI);
        mailUI.SetActive(true);
    }
}