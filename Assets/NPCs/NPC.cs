using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuantumTek.QuantumDialogue;
public abstract class NPC : MonoBehaviour
{
    public GameObject DialoguePrefab;
    public List<QD_Dialogue> Dialogues;
    public List<string> Conversations;
    public int DialogueCount = 0;

    [SerializeField]
    protected DialogueTracker CurrDialogue;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void Interact();
}
