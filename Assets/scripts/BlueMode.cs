using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMode : MonoBehaviour
{
    private bool isBlue = false;

    // initialize the normal lights to change back to
    private Light[] normalLights;

    void Start()
    {
        normalLights = Object.FindObjectsOfType<Light>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            ChangeBlue();
            isBlue = !isBlue;
        }
    }

    void ChangeBlue()
    {
        Light[] lights = Object.FindObjectsOfType<Light>();

        if (isBlue)
        {
            lights = normalLights;
         }
        else
        {
            foreach (Light light in lights)
            {
                light.color = Color.blue;
            }
        }

    }
}
