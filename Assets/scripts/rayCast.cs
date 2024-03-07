using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayScript : MonoBehaviour
{
    public float contactDistance;
    public GameObject objActive;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            RaycastHit isHit;
            //Structure used to get information back from a raycast

            Ray contactMade = new Ray(transform.position, transform.forward);
            //Ray - Representation of rays

            Debug.DrawRay(transform.position, transform.forward * contactDistance, Color.red);

            // if hitting a collider
            if (Physics.Raycast(contactMade, out isHit, contactDistance))
            {

                if (isHit.transform.tag == "test cast")
                {
                    Debug.Log("contact made");
                    objActive.SetActive(true);
                }
            }

        }
        
    }
}

        

