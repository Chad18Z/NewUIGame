﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ObjectiveComplete : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI finalScoreObject;

    [SerializeField]
    TextMeshProUGUI speedBonusObject;

    int speedBonusMultiplier = 1000;

    [SerializeField]
    float slowTime = 120f; // In seconds

    [SerializeField]
    float fastTime = 20f; // In seconds

    ScoreController scoreController;
    Timer timer;

    // Score from killing pacmen
    int rawScore = 0;

    // Extra points awarded for clearning the level quickly
    int speedBonus = 0;

    private void Start()
    {
        scoreController = GameObject.FindGameObjectWithTag("scoreController").GetComponent<ScoreController>();
        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        Cursor.visible = true;
        Time.timeScale = 0;

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
        // Here we'll check to see if the player should be awarded the next portal
        if (NextPortalAwarded())
        {
            SceneManager.LoadScene("PortalAwarded");

        }
        else
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Start");
        }
    }

    bool NextPortalAwarded()
    {
        LevelObject currentPortal = GameObject.FindGameObjectWithTag("availablePortals").GetComponent<AvailablePortals>().ActivePortal;
        if (rawScore >= currentPortal.requiredScore && speedBonus >= currentPortal.requiredSpeedBonus)
        {
            return true;
        }
        else
        {
            return false;
        }      
    }
}
