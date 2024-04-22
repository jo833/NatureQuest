using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenSign : MonoBehaviour
{
    AudioSource source;
    Collider soundTrigger;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider collider)
    {
        source.Play();
    }

}
