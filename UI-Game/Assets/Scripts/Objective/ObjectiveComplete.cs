using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectiveComplete : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI finalScoreObject;

    [SerializeField]
    TextMeshProUGUI speedBonusObject;

    [SerializeField]
    GameObject resumeButton;

    int speedBonusMultiplier = 1000;

    [SerializeField]
    float slowTime = 120f; // In seconds

    [SerializeField]
    float fastTime = 20f; // In seconds

    ScoreController scoreController;
    Timer timer;

    AvailablePortals availablePortals;

    // Score from killing pacmen
    int rawScore = 0;

    // Extra points awarded for clearning the level quickly
    int speedBonus = 0;

    private void Start()
    {
       
        availablePortals = GameObject.FindGameObjectWithTag("availablePortals").GetComponent<AvailablePortals>();
        scoreController = GameObject.FindGameObjectWithTag("scoreController").GetComponent<ScoreController>();
        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        Cursor.visible = true;
        Time.timeScale = 0;

        resumeButton.GetComponent<Button>().Select();
        DisplayFinalScore();
    }

    void DisplayFinalScore()
    {
        rawScore = scoreController.Score;
        float time = timer.TimeLevelComplete;

        speedBonus = CalculateSpeedBonus(time);
        int finalScore = CalculateFinalScore(rawScore, speedBonus);
        speedBonusObject.text = "+" + speedBonus + " speed bonus!";
        finalScoreObject.text = "Score: " + finalScore.ToString();
    }

    int CalculateFinalScore(int rawScore, int speedBonus)
    {
        return speedBonus + rawScore;
    }

    int CalculateSpeedBonus(float time)
    {
        float hTime = (time - fastTime) / (slowTime - fastTime);
        if (hTime < 0) hTime = 0;
        else if (hTime > 1) hTime = 1;
        return Mathf.RoundToInt((1 - hTime) * speedBonusMultiplier);
    }

    public void OnContinueButtonPressed()
    {
        if (availablePortals.isInPlaylistMode)
        {
            availablePortals.playlistIndex++;
            if (availablePortals.playlistIndex >= availablePortals.portalPlaylist.Count)
            {
                availablePortals.playlistIndex = 0;
            }
            Time.timeScale = 1;
            SceneManager.LoadScene(availablePortals.portalPlaylist[availablePortals.playlistIndex].sceneName);
        }
        // Here we'll check to see if the player should be awarded the next portal
        else if (NextPortalAwarded())
        {
            SceneManager.LoadScene("PortalAwarded");

        }
        else
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("LevelSelect");
        }
    }

    bool NextPortalAwarded()
    {
        LevelObject currentPortal = availablePortals.ActivePortal;

        // This means that the player has beaten the game
        if (currentPortal.reward == null)
        {
            // CHANGE THIS LATER....PLAYER HAS BEATEN THE GAME!
            return false;
        }

        if (rawScore >= currentPortal.requiredScore && speedBonus >= currentPortal.requiredSpeedBonus
            && !availablePortals.GetPortals().Contains(currentPortal.reward)) 
        {
            return true;
        }
        else
        {
            return false;
        }      
    }
}
