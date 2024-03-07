using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("please work prayer emoji");
        audioSource.Play();
    }

    // have to create a new component audio Source in the cube or whatever unmeshed object you are adding to
    // add your audio to he audio resource component of that
    // remember to click OFF playOnAwake

}
