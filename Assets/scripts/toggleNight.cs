using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleNight : MonoBehaviour
{

    private bool isNight = false;
    public Material day_mesh;
    public Material night_mesh;

       // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            isNight = !isNight;
            ToggleNightMode();
        }
    }

    private void ToggleNightMode()
    {
        // turn off/on all lights
        Light[] lights = Object.FindObjectsOfType<Light>();
        foreach (Light light in lights)
        {
            light.enabled = !isNight;
        }

        // toggle the mesh render
        GameObject mesh_background = GameObject.FindGameObjectWithTag("background");

        if (isNight)
        {
            mesh_background.GetComponent < MeshRenderer >().material = night_mesh;
        }
        else
        {
            mesh_background.GetComponent < MeshRenderer >().material = day_mesh;
        }


    }
}
