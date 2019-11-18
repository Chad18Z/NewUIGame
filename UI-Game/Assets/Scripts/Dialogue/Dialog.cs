using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    Teletype teletype;

    // Start is called before the first frame update
    void Start()
    {
        teletype = GameObject.FindGameObjectWithTag("teletype").GetComponent<Teletype>();
    }


}
