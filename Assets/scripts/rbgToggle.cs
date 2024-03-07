using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbgToggle : MonoBehaviour
{

    public GameObject lightParent;
    public Light[] lights;
    private bool isLightBlue = true;
    private bool isPlayerWithinTrigger = false;

    private void Start()
    {
        lights = lightParent.GetComponentsInChildren<Light>();
    }

    private void ToggleLight()
    {
        Debug.Log("toggled rgb!");
        foreach (Light light in lights)
        {

            if (isLightBlue)
            {
                light.color = Color.red;
            } else
            {
                light.color = Color.blue; 
            }
        }

        isLightBlue = !isLightBlue;
    }

    private void OnTriggerEnter(Collider other)
    {
        isPlayerWithinTrigger = true;
    }

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
