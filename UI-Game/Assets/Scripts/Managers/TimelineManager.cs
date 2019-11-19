using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineManager : MonoBehaviour
{
    GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void FlipCharacter()
    {
        Vector3 scale = player.transform.localScale;
        scale.x *= -1;
        player.transform.localScale = new Vector3(scale.x, 1, 1);
    }
}
