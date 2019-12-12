using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    bool isPaused = false;

    [SerializeField]
    GameObject controlSchemePrefab;

    [SerializeField]
    GameObject gamepadSchemePrefab;

    [SerializeField]
    GameObject controlsButton;

    GameObject instructions;

    AvailablePortals availablePortals;

    // Instantiation of black background object
    Canvas pauseCanvas;

    public static bool inControls = false;

    // Start is called before the first frame update
    void Start()
    {
        // Add this script's delegate as a listener for the game paused event
        GameManager.AddGamePausedEventListener(Pause);

        // Get a reference to the canvas with buttons attached to this gameobject
        pauseCanvas = GetComponentInChildren<Canvas>();

        // Create a fade canvas
        pauseCanvas.enabled = false;

        availablePortals = GameObject.FindGameObjectWithTag("availablePortals").GetComponent<AvailablePortals>();
    }

    // Delegate for the game paused event
    void Pause()
    {
        // If Control options menu is open
        if (inControls) return;

        if (isPaused)
        {
            EventSystem.current.SetSelectedGameObject(null);
            Cursor.visible = false;
            pauseCanvas.enabled = false;
            isPaused = false;
            
        }
        else
        {
            // Set Controls button as selected
            controlsButton.GetComponent<Button>().Select();

            Cursor.visible = true;
            pauseCanvas.enabled = true;
            isPaused = true;
        }
    }

    public void HandleQuit()
    {
        Time.timeScale = 1;
        
        if (availablePortals.isInPlaylistMode)
        {
            SceneManager.LoadScene("PlaylistSelect");
        }
        else SceneManager.LoadScene("LevelSelect");
    }

    public void HandleControls()
    {
        MenuButtonSelected.PlayMenuButtonSelectedSound();
        inControls = true;
        pauseCanvas.enabled = false;

        if (Gamepad.current != null)
        {
            instructions = Instantiate(gamepadSchemePrefab);
            instructions.GetComponent<GamepadSchemeSelect>().AddHandler(ReturnHandler);
        }
        else
        {
            instructions = Instantiate(controlSchemePrefab);
            instructions.GetComponent<ControlSchemeSelect>().AddHandler(ReturnHandler);
        }
    }
            
        

    void ReturnHandler()
    {

        MenuButtonSelected.PlayMenuButtonSelectedSound();

        // Set Controls button as selected
        controlsButton.GetComponent<Button>().Select();

        pauseCanvas.enabled = true;
        inControls = false;

        if (instructions != null)
        {
            Destroy(instructions);
        }
    }

}
