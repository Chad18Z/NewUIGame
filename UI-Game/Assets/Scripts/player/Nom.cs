﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(KillTimer());
    }

    IEnumerator KillTimer()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
