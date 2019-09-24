﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectiveFailed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Time.timeScale = 0;
    }


    public void HandleContinue()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start");
    }
}
