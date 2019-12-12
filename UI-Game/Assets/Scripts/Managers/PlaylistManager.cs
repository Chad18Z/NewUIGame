using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlaylistManager : MonoBehaviour
{
    [SerializeField]
    GameObject dragablePortal;

    [SerializeField]
    GameObject placeholder;

    [SerializeField]
    GameObject portalPanel;

    [SerializeField]
    GameObject playlistPanel;

    List<LevelObject> portals;

    AvailablePortals availablePortals;

    AudioSource pop;

    [SerializeField]
    GameObject firstSelected;

    public GameObject dragItem;
    GameObject dropItem;

    public Canvas dragCanvas;

    GameObject currentSelectedObject;

    Dictionary<GameObject, LevelObject> portalDict = new Dictionary<GameObject, LevelObject>();
    Dictionary<GameObject, LevelObject> playlistDict = new Dictionary<GameObject, LevelObject>();

    private void Start()
    {
        pop = gameObject.GetComponent<AudioSource>();
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

            portalDict.Add(dragItem, portal);

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
        dragItem.GetComponent<Button>().enabled = false;
        currentSelectedObject = selectedObject;
        dragItem.transform.SetParent(dragCanvas.transform);
        dragItem.GetComponent<Image>().SetNativeSize();
        dragItem.transform.localScale = 1.1f * dragItem.transform.localScale;
        dragItem.GetComponent<Image>().raycastTarget = false;
    }

    public void Drop()
    {
        if (playlistDict.Count >= 9) return;
        GameObject droppedItem = Instantiate(dragablePortal, playlistPanel.transform);
        droppedItem.GetComponent<Button>().enabled = false;
        droppedItem.transform.SetSiblingIndex(playlistDict.Count);
        playlistDict.Add(droppedItem, portalDict[currentSelectedObject]);
        droppedItem.GetComponentInChildren<TextMeshProUGUI>().text = dragItem.GetComponentInChildren<TextMeshProUGUI>().text;
        pop.Play();
        EventSystem.current.SetSelectedGameObject(firstSelected);
    }

    public void OnCancel()
    {
        availablePortals.isInPlaylistMode = false;
        SceneManager.LoadScene("PlaymodeSelect");
    }

    public void OnBegin()
    {
        availablePortals.isInPlaylistMode = true;
        availablePortals.playlistIndex = 0;
        availablePortals.portalPlaylist.Clear();

        foreach(KeyValuePair<GameObject, LevelObject> entry in playlistDict)
        {
            availablePortals.portalPlaylist.Add(entry.Value);
        }

        SceneManager.LoadScene(availablePortals.portalPlaylist[0].sceneName);
    }

}
