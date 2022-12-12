using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkedToPostman : Action
{
    public override void DoAction()
    {
        StoryManager manager = StoryManager.Instance;
        manager.TalkedToPostMan = true;
        if (manager.TalkedToPostMan && manager.TalkedToShopkeeper == true) {
            manager.Characters["POSTMAN"].DialogueCount = 1;
        }
    }
}
