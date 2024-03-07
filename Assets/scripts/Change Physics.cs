using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePhysics : MonoBehaviour

{
    public GameObject controller;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set rigidbody based on inputs k and j
        if (Input.GetKeyDown(("k")))
        {
            controller.GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log("Rigidbody on");
        }

        if (Input.GetKeyDown("j"))
        {
            controller.GetComponent<Rigidbody>().isKinematic = false;
            Debug.Log("Rigidbody off");
        }
   
    }
}
