using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterLetter : Action
{
    public override void DoAction()
    {
        StoryManager manager = StoryManager.Instance;
        manager.Characters["POSTMAN"].DialogueCount = 4;
        manager.Characters["SHOPKEEPER"].DialogueCount = 2;
    }
}
