using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsScroller : MonoBehaviour
{
    [SerializeField]
    GameObject creditsPanel;

    Animator anim;
    
    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        
    }

    private void Update()
    {
        
    }
}
