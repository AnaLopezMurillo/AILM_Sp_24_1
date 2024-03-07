using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampToggle : MonoBehaviour
{
    public Light pointLight;
    private bool isLightOn = true;
    private bool isPlayerWithinTrigger = false;

    // will actually toggle the light
    private void ToggleLight()
    {
        Debug.Log("Toggled!");
        isLightOn = !isLightOn;
        pointLight.enabled = isLightOn;
    }

    // we have entered the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        isPlayerWithinTrigger = true;
    }

    // exited the trigger zone
    private void OnTriggerExit(Collider other)
    {
        isPlayerWithinTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerWithinTrigger && Input.GetKeyDown(KeyCode.Z))
        {
            ToggleLight();
        }
        
    }


}
