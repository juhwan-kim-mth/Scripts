using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiatinng : MonoBehaviour
{
    
    public GameObject[] ball;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(ball, transform.position, Quaternion.identity);
        //Invoke("RandomBall", 5f);
		InvokeRepeating("RandomBall",2f,1f);
		
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
			print("Mouse Clicked");
            CancelInvoke("RandomBall");
        }   
    }

    void RandomBall()
    {
        int randomNumber = Random.Range(0, ball.Length);
        Instantiate(ball[randomNumber], transform.position, Quaternion.identity); 
    }
}
