using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AskedFarmerAboutShop : Action
{
    public override void DoAction()
    {
        StoryManager manager = StoryManager.Instance;
        manager.Characters["POSTMAN"].DialogueCount = 2;
    }
}
