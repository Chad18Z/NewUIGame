﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaymodeSelect : MonoBehaviour
{
    public void OnNormalModeSelected()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void OnPortalPlaylistModeSelected()
    {

    }

    public void OnBackSelected()
    {
        SceneManager.LoadScene("Start");
    }
}