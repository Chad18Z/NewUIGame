using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    GameObject placeholder;

    [SerializeField]
    GameObject portalButton;

    [SerializeField]
    GameObject portalPanel;

    [SerializeField]
    GameObject backButton;

    List<LevelObject> portals;

    List<GameObject> buttons = new List<GameObject>();

    AvailablePortals availablePortals;

    private void Start()
    {
        availablePortals = GameObject.FindGameObjectWithTag("availablePortals").GetComponent<AvailablePortals>();
        availablePortals.isInPlaylistMode = false;
        portals = availablePortals.GetPortals();

        PopulateButtons();

    }

    void PopulateButtons()
    {
        // Levels and portals are the same thing
        foreach (LevelObject portal in portals)
        {
            GameObject button = Instantiate(portalButton, portalPanel.transform);
            button.name = portal.name;
            button.GetComponentInChildren<TextMeshProUGUI>().text = portal.levelName;
            button.GetComponent<Button>().onClick.AddListener(OnLevelSelected);
            buttons.Add(button);
        }

        // Fill the row (if needed) for asthetic value
        if (portals.Count >= 10) return;

        for (int i = 0; i < (5 - portals.Count); i++)
        {
            Instantiate(placeholder, portalPanel.transform);
        }

        ConnectButtons();
    }

    void ConnectButtons()
    {
        EventSystem.current.firstSelectedGameObject = buttons[0];
        Navigation nav = backButton.GetComponent<Button>().navigation;
        nav.selectOnUp = buttons[0].GetComponent<Button>();
        backButton.GetComponent<Button>().navigation = nav;

        for (int i = 0; i < buttons.Count; i++)
        {
            Button buttonObject = buttons[i].GetComponent<Button>();
            nav = buttonObject.navigation;
            nav.selectOnDown = backButton.GetComponent<Button>();

            if (i == buttons.Count - 1)
            {
                nav.selectOnRight = buttons[0].GetComponent<Button>();
            }
            else
            {
                nav.selectOnRight = buttons[i + 1].GetComponent<Button>();
            }

            if (i == 0)
            {
                nav.selectOnLeft = buttons[buttons.Count - 1].GetComponent<Button>();
            }
            else
            {
                nav.selectOnLeft = buttons[i - 1].GetComponent<Button>();
            }
            buttonObject.navigation = nav;           
        }
    }

    public void OnLevelSelected()
    {
        // Get a reference to the currently selected button
        GameObject callingButton = EventSystem.current.currentSelectedGameObject;

        // The portal that the player selected to enter
        LevelObject currentPortal = FindPortal(callingButton);

        // Set portal as active in singleton availablePortals object
        availablePortals.ActivePortal = currentPortal;

        // Change the scene 
        SceneManager.LoadScene(currentPortal.sceneName);
    }


    // Finds the portal associated with a button
    LevelObject FindPortal(GameObject button)
    {
        foreach (LevelObject portal in portals)
        {
            if (button.name == portal.name)
            {
                return portal;
            }              
        }

        Debug.Log("Portal not found, please be sure to add it to list");
        return null;
    }

    public void OnBack()
    {
        SceneManager.LoadScene("Start");
    }
}
