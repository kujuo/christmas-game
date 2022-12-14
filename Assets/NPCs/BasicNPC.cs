using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuantumTek.QuantumDialogue;
using UnityEngine.UI;

public class BasicNPC : NPC
{
    public string NPCName;

    public override void Interact()
    {
        Player.Instance.Pause = true;
        Time.timeScale = 0.0f;
        GameObject DialogueUI = Instantiate(DialoguePrefab);
        CurrDialogue = DialogueUI.GetComponentInChildren<DialogueTracker>();
        CurrDialogue.SetDialogue(Dialogues[DialogueCount]);

        CurrDialogue.SetConversation(Conversations[DialogueCount]);
        QD_Dialogue dialogue = Dialogues[DialogueCount];
        Sprite icon = dialogue.GetSpeaker(NPCName).Icon;
        DialogueUI.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Image>().sprite = icon;
    }
} 
