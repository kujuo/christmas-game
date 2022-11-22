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
        CurrDialogue = Instantiate(Dialogue).GetComponentInChildren<DialogueTracker>();
        CurrDialogue.SetConversation(CurrentConversation);
    }
} 
