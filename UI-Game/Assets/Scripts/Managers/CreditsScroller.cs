using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsScroller : MonoBehaviour
{
    
    private void Start()
    {
        StartCoroutine("SceneChangeTimer");
        
    }

    IEnumerator SceneChangeTimer()
    {
        yield return new WaitForSeconds(22f);
        Destroy(GameObject.FindGameObjectWithTag("music"));
        SceneManager.LoadScene("Start");
    }
}
