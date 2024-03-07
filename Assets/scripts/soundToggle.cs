using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundToggle : MonoBehaviour
{

    public AudioSource audioSource;
    private bool soundOn = true;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            soundOn = !soundOn;
            audioSource.enabled = soundOn;

        }
    }
}
