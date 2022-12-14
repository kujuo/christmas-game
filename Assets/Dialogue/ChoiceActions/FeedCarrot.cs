using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedCarrot : Action
{
    public GameObject teleport1;
    public GameObject teleport2;
    public override void DoAction()
    {
        StoryManager manager = StoryManager.Instance;
        manager.Characters["SVEN"].DialogueCount = 0;
        manager.Characters["REINDEER_FARMER"].DialogueCount = 2;
        manager.Characters["POSTMAN"].DialogueCount = 3;
    }
}
