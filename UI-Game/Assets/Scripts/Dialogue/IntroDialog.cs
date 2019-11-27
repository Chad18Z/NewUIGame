using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroDialog : MonoBehaviour
{
    int index = 0;
    Teletype teletype;
    string[] text =
    {
        "Wha- I'm a ghost!",
        "But I don't remember dying",
        "...and that's something I'd certainly never forget",
        "I was celebrating the holidays with coworkers...",
        "...when all of a sudden....",
        "....[distracted] Hey look! Cookies"
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
