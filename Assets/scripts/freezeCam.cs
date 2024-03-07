using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezeCam : MonoBehaviour
{
    public GameObject makeVisible;

    // starts once the player enters the space of the object
    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Player"))
        {
            go.GetComponent<FirstPersonController>().enabled = false;
            makeVisible.SetActive(true);
        }
    }

}
