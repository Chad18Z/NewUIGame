using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    AudioSource mouseOver;

    private void Start()
    {
        AudioSource[] sources = GetComponents<AudioSource>();

        // Assign first audiosource attached to the gameobject
        mouseOver = sources[0];
    }
    public void OnInstructionsButtonPressed()
    {
        MenuButtonSelected.PlayMenuButtonSelectedSound();
        SceneManager.LoadScene("Instructions");
    }

    public void OnPlayButtonClicked()
    {
        MenuButtonSelected.PlayMenuButtonSelectedSound();
        SceneManager.LoadScene("LevelSelect");
    }

    public void OnCreditsButtonClicked()
    {
        MenuButtonSelected.PlayMenuButtonSelectedSound();
        SceneManager.LoadScene("Credits");
    }

    public void OnQuitButtonClicked()
    {
        //MenuButtonSelected.PlayMenuButtonSelectedSound();
        Application.Quit();
    }

    public void OnOptionsClicked()
    {
        MenuButtonSelected.PlayMenuButtonSelectedSound();
        SceneManager.LoadScene("Options");
    }

    public void OnMouseOver()
    {
        mouseOver.Play();
    }
}
