using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using UnityEngine.Profiling;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    [SerializeField]
    private GameObject _pauseMenu;

    [Tooltip("The Transform used to position the items to be crafted.")]
    [SerializeField]
    private Transform _raycaster;

    private LayerMask _focusLayers;
    private LayerMask _craftLayers;
    private GameObject _itemObj;
    private string _currItem = "";

    private Transform _cam;
    private GameObject _interactionObj;

    private bool _showingMenu = false;
    public bool Talking = false;

    /// <summary>
    /// The type of the interaction if some object that the player
    /// is looking at
    /// </summary>
    private enum Interaction
    {
        GrabTool, GrabItem, OpenContainer, None
    }
    private Interaction _interaction;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    /// <summary>
    /// Check where the floor is on a navmesh to craft a item
    /// </summary>
    UnityEngine.AI.NavMeshHit _hitTerrain;
    RaycastHit _hit;

    void Start()
    {
        _cam = Camera.main.transform;


        _focusLayers = LayerMask.GetMask("Default", "CraftableItem");
        _craftLayers = LayerMask.GetMask("Default");
    }


    void Update()
    {
        if (!Talking && Input.GetMouseButtonDown(0)) CheckPlayerFocus();
        
    }

    /// <summary>
    /// Checks where the player camera is focusing and
    /// display a message about it.
    /// </summary>
    void CheckPlayerFocus()
    {
        if (UnityEngine.Physics.Raycast(_cam.position, _cam.forward, out _hit, 5, _focusLayers.value))
        {
            if (_hit.transform.gameObject.tag == "NPC")
            {
                NPC npc = _hit.transform.gameObject.GetComponent<NPC>();
                Debug.Log("hello");
                npc.Interact();
            }
            //else if (_hit.transform.gameObject.tag == "Tool")
            //{
            //    _actionText.Text = "Press (E) to grab " + _hit.transform.gameObject.GetComponent<Tool>().ItemName;
            //    _interaction = Interaction.GrabTool;
            //    _interactionObj = _hit.transform.gameObject;
            //}
            //else if (_hit.transform.gameObject.tag == "Resource")
            //{
            //    Resource resource = _hit.transform.gameObject.GetComponent<Resource>();
            //    _actionText.Text = "Resource: " + resource.Item.ItemName;
            //}
            //else if (_hit.transform.gameObject.tag == "Container")
            //{
            //    _actionText.Text = "Press (E) to open Container";
            //    _interaction = Interaction.OpenContainer;
            //    _interactionObj = _hit.transform.gameObject;
            //}
            //else if (_hit.transform.gameObject.tag == "Interactable")
            //{
            //    _actionText.Text = _hit.transform.gameObject.name;
            //    _interaction = Interaction.None;
            //    _interactionObj = _hit.transform.gameObject;
            //}
            //else
            //{
            //    _interactionObj = null;
            //    _actionText.Text = "";
            //}
        }
        //else
        //{
        //    _interactionObj = null;
        //    _actionText.Text = "";
        //}

    }


    void SetMenu()
    {
        _showingMenu = !_showingMenu;
        Cursor.visible = _showingMenu;
        if (_showingMenu)
            Time.timeScale = 0.0f;
        else
            Time.timeScale = 1.0f;
    }

    public void ShowPauseMenu()
    {
        SetMenu();
        _pauseMenu.SetActive(_showingMenu);
    }

    ////When an item is selected from the inventory
    //public void SelectItem(string name, Inventory.Type type)
    //{
    //    Item item = Manager.GetInventoryItem(name);
    //    _currItem = name;
    //    _currType = type;
    //    _inventoryUI.SelectItem(item);
    //}

    /// <summary>
    /// Take or give some item
    /// from the player to another inventory
    /// used for containers
    /// </summary>
    /// <param name="taking"></param>
    //public void TransferItem(bool taking)
    //{

    //    if (_currItem == "")
    //    {
    //        return;
    //    }

    //    Inventory otherInventory = _interactionObj.GetComponent<Inventory>();

    //    float amount = _inventoryUI.GetAmount();

    //    if (taking)
    //    {
    //        if (_currType == Inventory.Type.Inventory)
    //            return;

    //        if (amount > otherInventory.Items[_currItem])
    //            amount = otherInventory.Items[_currItem];

    //        if (_inventory.TryAdd(_currItem, amount))
    //            otherInventory.TryAdd(_currItem, -amount);

    //        if (!otherInventory.Items.ContainsKey(_currItem))
    //            _currItem = "";
    //    }
    //    else
    //    {
    //        if (_currType != Inventory.Type.Inventory)
    //            return;

    //        if (amount > _inventory.Items[_currItem])
    //            amount = _inventory.Items[_currItem];

    //        //Drop the Tool if it is being held
    //        if (_toolHandler.CurrentTool != null)
    //            if (_toolHandler.CurrentTool.ItemName == _currItem)
    //                if (amount > _inventory.Items[_currItem] - 1)
    //                {
    //                    Destroy(_toolHandler.ToolObject);
    //                    _toolHandler.CurrentTool = null;
    //                }

    //        if (otherInventory.TryAdd(_currItem, amount))
    //            _inventory.TryAdd(_currItem, -amount);

    //        if (!_inventory.Items.ContainsKey(_currItem))
    //            _currItem = "";
    //    }

    //    _inventoryUI.Draw(_inventory);
    //    _inventoryUI.Draw(otherInventory);
    //}
}
