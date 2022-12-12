using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSnowman : Action
{
    public override void DoAction()
    {
        StoryManager manager = StoryManager.Instance;
        manager.Characters["LITTLE_GIRL"].DialogueCount = 2;
        manager.Characters["SVEN"].DialogueCount = 1;
    }
}
