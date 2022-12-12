using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public static StoryManager Instance { get; private set; }
    public bool TalkedToShopkeeper = false;
    public bool TalkedToReindeer = false;
    public bool TalkedToPostMan = false;
    public GameObject SHOPKEEPER;
    public GameObject REINDEER_FARMER;
    public GameObject LITTLE_GIRL;
    public GameObject POSTMAN;
    public GameObject SVEN;
    public Dictionary<string, NPC> Characters = new Dictionary<string, NPC>();
    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        Characters.Add("SHOPKEEPER", SHOPKEEPER.GetComponent<NPC>());
        Characters.Add("REINDEER_FARMER", REINDEER_FARMER.GetComponent<NPC>());
        Characters.Add("LITTLE_GIRL", LITTLE_GIRL.GetComponent<NPC>());
        Characters.Add("POSTMAN", POSTMAN.GetComponent<NPC>());
        Characters.Add("SVEN", SVEN.GetComponent<NPC>());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
