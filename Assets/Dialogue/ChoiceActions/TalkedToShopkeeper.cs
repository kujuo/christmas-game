using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkedToShopkeeper : Action
{
    public override void DoAction()
    {
        StoryManager manager = StoryManager.Instance;
        manager.TalkedToShopkeeper = true;
        if (manager.TalkedToReindeer)
        {
            print(manager.Characters["REINDEER_FARMER"].DialogueCount);
            manager.Characters["REINDEER_FARMER"].DialogueCount = 1;
        }
        if (manager.TalkedToPostMan)
        {
            manager.Characters["POSTMAN"].DialogueCount = 1;
        }
        manager.Characters["SHOPKEEPER"].DialogueCount = 1;
    }
}
