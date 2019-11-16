using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isWalking", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("isWalking", false);
        }
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
