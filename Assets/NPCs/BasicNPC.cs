using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicNPC : NPC
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        Player.Instance.Pause = true;
        Time.timeScale = 0.0f;
        CurrDialogue = Instantiate(DialoguePrefab).GetComponentInChildren<DialogueTracker>();
        CurrDialogue.SetDialogue(dialogue);
        CurrDialogue.SetConversation(CurrentConversation);
    }
} 
