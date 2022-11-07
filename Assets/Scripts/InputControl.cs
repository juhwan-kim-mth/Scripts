using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    
    //public float speed;

    public GameObject ball;
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

        // if (Input.GetButtonDown("Jump"))
        //{
        //    GetComponent<Renderer>().material.color = Color.green; 
        //}

        //if (Input.GetButtonUp("Jump"))
        //{
        //    GetComponent<Renderer>().material.color = Color.yellow;
        // }
        // float xInput = Input.GetAxis("Horizontal");
        // float yInput = Input.GetAxis("Vertical");
        //
        // transform.Translate(xInput * speed * Time.deltaTime, 0, 0);
        // transform.Translate(0, yInput * speed * Time.deltaTime, 0);

        /*if (Input.GetButtonDown("Fire1"))
        {
            print("Left Click");
            //print(Input.mousePosition.x + " " + Input.mousePosition.y);
            Vector3 pos = Input.mousePosition;
            pos.z = 10f;

            pos = Camera.main.ScreenToWorldPoint(pos);  //Converting screen coordinates to world coordinates
            Instantiate(ball, pos, Quaternion.identity);
        }

        if (Input.GetButtonDown("Fire2"))
        {
            print("Right Click");
        }*/


    }        
    void OnMouseDown()
    { 
        Destroy(gameObject);
    }
}
