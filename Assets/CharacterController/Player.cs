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
    private Renderer LastObj = null;
    private Color LastObjColor;

    private Transform _cam;

    private bool _showingMenu = false;
    public bool Pause = false;

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
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.Confined;
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
        if (!Pause) CheckPlayerFocus();
        if (!Pause && Input.GetMouseButtonDown(0)) PlayerInteract();
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
                if (LastObj == null)
                {
                    LastObj = _hit.transform.gameObject.GetComponent<Renderer>();
                    LastObjColor = LastObj.material.color;
                    LastObj.material.color = LastObjColor * Color.red;
                }
            }
            else if (LastObj != null)
            {
                LastObj.material.color = LastObjColor;
                LastObj = null;
            }
        }
        else if (LastObj != null)
        {
            LastObj.material.color = LastObjColor;
            LastObj = null;
        }
    }

    void PlayerInteract()
    {
        if (UnityEngine.Physics.Raycast(_cam.position, _cam.forward, out _hit, 5, _focusLayers.value))
        {
            if (_hit.transform.gameObject.tag == "NPC")
            {
                NPC npc = _hit.transform.gameObject.GetComponent<NPC>();
                Color startcolor = _hit.transform.gameObject.GetComponent<Renderer>().material.color;
                _hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.red;
                Cursor.lockState = CursorLockMode.Confined;
                npc.Interact();
            }
        }

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
}
