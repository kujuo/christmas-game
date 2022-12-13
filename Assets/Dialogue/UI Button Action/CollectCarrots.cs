using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCarrots : NPC
{
    public override void Interact()
    {
        //Player.Instance.Pause = true;
        //Time.timeScale = 0.0f;
        CurrDialogue = Instantiate(DialoguePrefab).GetComponentInChildren<DialogueTracker>();
        CurrDialogue.SetDialogue(Dialogues[DialogueCount]);
        CurrDialogue.SetConversation("After Snowman");
    }
}
