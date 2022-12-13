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
        // sets the ui active


        // when hit button, you call code
        //CurrDialogue = Instantiate(DialoguePrefab).GetComponentInChildren<DialogueTracker>();
        //CurrDialogue.SetDialogue(Dialogues[DialogueCount]);
        //CurrDialogue.SetConversation("After Snowman");
    }
}
