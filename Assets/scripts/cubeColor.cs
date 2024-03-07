using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeColoe : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        //// if spacebar is pressed
        //if (Input.GetKeyDown(KeyCode.Space))
        //    Debug.Log("Space bar pressed!!");

        //if (Input.GetKeyUp(KeyCode.Space))
        //    Debug.Log("Space bar released!!");


        if (Input.GetKeyDown(KeyCode.R)) {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }

        if (Input.GetKeyUp(KeyCode.R))
            gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (Input.GetKeyDown(KeyCode.B))
            gameObject.GetComponent<Renderer>().material.color = Color.blue;

    }
}
