using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactParticleManager : MonoBehaviour
{
    ParticleSystem[] particleSystems;

    private void Start()
    {
        particleSystems = GetComponentsInChildren<ParticleSystem>();
    }

    private void Update()
    {
        if (!particleSystems[0].isPlaying && !particleSystems[1].isPlaying)
        {
            Destroy(gameObject);
        }
    }
}
    
