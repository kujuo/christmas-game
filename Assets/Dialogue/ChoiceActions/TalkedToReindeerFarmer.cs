using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkedToReindeerFarmer : Action
{
    public override void DoAction()
    {
        StoryManager manager = StoryManager.Instance;
        manager.TalkedToReindeer = true;
        if (manager.TalkedToShopkeeper && manager.TalkedToReindeer)
        {
            manager.Characters["REINDEER_FARMER"].DialogueCount = 1;
        }
    }
}
