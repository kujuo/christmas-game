using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSnowman : Action
{
    public GameObject carrotsUI;
    public GameObject character;

    public override void DoAction()
    {
        Destroy(character.GetComponent<BasicNPC>().dialogueBox);
        GameObject carrots = Instantiate(carrotsUI);
        carrots.SetActive(true);
        StoryManager manager = StoryManager.Instance;
        manager.Characters["LITTLE_GIRL"].DialogueCount = 2;
        manager.Characters["SVEN"].DialogueCount = 1;
    }
}
