using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTest : MonoBehaviour
{
	//Vector3 pos;
	public float angularSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //pos = new Vector3(1f,2f,3f);
		//print(pos.x);

		//print(transform.position);
		//transform.position = new Vector3(1,1,1);
		angularSpeed = 0.1f;
		
    }

    // Update is called once per frame
    void Update()
    {
        //speed = new Vector3(0f,0.01f,0f);
		//transform.position = transform.position + speed;
		transform.Rotate(angularSpeed,0,0);
    }
}
