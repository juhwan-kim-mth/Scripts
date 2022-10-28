using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     GetComponent<Renderer>().material.color = Color.green;
        // }
        //
        // if (Input.GetKeyUp(KeyCode.Space))
        // {
        //     print("Space button is released");
        //     GetComponent<Renderer>().material.color = Color.yellow;
        // }

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Renderer>().material.color = Color.green; 
        }

        if (Input.GetButtonUp("Jump"))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
