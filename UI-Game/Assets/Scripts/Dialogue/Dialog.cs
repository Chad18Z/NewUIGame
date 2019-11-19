﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    int index = 0;
    Teletype teletype;
    string[] text =
    {
        "Best company Christmas party ever!",
        "Apparently some smartass added shrooms to their cookie recipe",
        "I knew morale would improve once I became the boss",
        "Anyhoo, come inside, we're about to present awards",
        "...and take that sheet off yer head, you look ridiculous!"
    };
    // Start is called before the first frame update
    void Start()
    {
        teletype = GameObject.FindGameObjectWithTag("teletype").GetComponent<Teletype>();
    }

    public void HandleSignal()
    {
        //Debug.Log("Signal received");
        if (index < text.Length)
        {
            ShowString(text[index]);
            index++;
        }
        else
        {
            Debug.Log("Out of range");
        }
    }

    void ShowString(string message)
    {
        teletype.ShowMessage(message);
    }


}