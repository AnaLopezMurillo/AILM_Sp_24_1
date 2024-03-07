using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRug : MonoBehaviour
{
    public Material normal_mesh;
    public Material alt_mesh;
    public GameObject gameobj;
    
    private bool isNormal = true;
    private bool isPlayerWithinTrigger = false;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isNormal = !isNormal;
            ChangeMesh();
        }
        
    }

    // only activate if player is within the trigger
    private void OnTriggerEnter(Collider other)
    {
        isPlayerWithinTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isPlayerWithinTrigger = false;
    }


    private void ChangeMesh()
    {
        if (isPlayerWithinTrigger)
        {
            if (isNormal)
            {
                gameobj.GetComponent<MeshRenderer>().material = normal_mesh;
            }
            else
            {
                gameobj.GetComponent<MeshRenderer>().material = alt_mesh;
            }
        }
    }
}
