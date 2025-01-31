using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverapebParticle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ItemBox"))
        {
            GetComponent<ParticleSystem>().Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("ItemBox"))
        {
            GetComponent<ParticleSystem>().Stop();
        }
    }
}
