using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnedAboutLittleGirl : Action
{
    public override void DoAction()
    {
        StoryManager manager = StoryManager.Instance;
        manager.Characters["LITTLE_GIRL"].DialogueCount = 1;
    }
}
