using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelectEffect : MonoBehaviour
{
    ParticleSystem ParticleSystem;

    void Start()
    {
        ParticleSystem = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (!ParticleSystem.isPlaying)
        {
            Destroy(gameObject);
        }
    }
}
