﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class PlaylistManager : MonoBehaviour
{
    [SerializeField]
    GameObject dragablePortal;

    [SerializeField]
    GameObject placeholder;

    [SerializeField]
    GameObject portalPanel;

    List<LevelObject> portals;

    AvailablePortals availablePortals;

    public GameObject dragItem;
    public Canvas dragCanvas;

    private void Start()
    {
        availablePortals = GameObject.FindGameObjectWithTag("availablePortals").GetComponent<AvailablePortals>();
        portals = availablePortals.GetPortals();

        PopulateButtons();
    }

    void PopulateButtons()
    {
        foreach (LevelObject portal in portals)
        {
            dragItem = Instantiate(dragablePortal, portalPanel.transform);
            dragItem.GetComponentInChildren<TextMeshProUGUI>().text = portal.levelName;

            EventTrigger trigger = dragItem.GetComponent<EventTrigger>();
            EventTrigger.Entry entryOne = new EventTrigger.Entry();
            entryOne.eventID = EventTriggerType.BeginDrag;
            entryOne.callback.AddListener((data) =>
            {
                StartDrag(data.selectedObject);
            });

            trigger.triggers.Add(entryOne);

            EventTrigger.Entry entryTwo = new EventTrigger.Entry();
            entryTwo.eventID = EventTriggerType.EndDrag;
            entryTwo.callback.AddListener((twoData) =>
            {
                StopDrag();
            });
            trigger.triggers.Add(entryTwo);

            EventTrigger.Entry entryThree = new EventTrigger.Entry();
            entryThree.eventID = EventTriggerType.Drag;
            entryThree.callback.AddListener((threeData) =>
            {
                Drag();
            });
            trigger.triggers.Add(entryThree);

        }

        // Fill the row (if needed) for asthetic value
        if (portals.Count >= 5) return;

        for (int i = 0; i < (5 - portals.Count); i++)
        {
            Instantiate(placeholder, portalPanel.transform);
        }
    }

    public void StopDrag()
    {
        Destroy(dragItem);
    }

    public void Drag()
    {
        dragItem.transform.position = Input.mousePosition;
    }

    public void StartDrag(GameObject selectedObject)
    {
        dragItem = Instantiate(selectedObject, Input.mousePosition, selectedObject.transform.rotation) as GameObject;
        dragItem.transform.SetParent(dragCanvas.transform);
        dragItem.GetComponent<Image>().SetNativeSize();
        dragItem.transform.localScale = 1.1f * dragItem.transform.localScale;
        dragItem.GetComponent<Image>().raycastTarget = false;
    }

}
