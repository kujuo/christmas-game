using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuantumTek.QuantumDialogue;
public abstract class NPC : MonoBehaviour
{
    public string CurrentConversation;
    public QD_Dialogue dialogue;
    public GameObject DialoguePrefab;

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
