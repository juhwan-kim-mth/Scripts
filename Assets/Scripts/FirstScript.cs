using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Testfunction();
        GetComponent<Rigidbody>().useGravity = false;
        GameObject enemy;
        enemy = GameObject.Find("Sphere");
        Destroy(enemy);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Testfunction()
    {
        print("Test function");
        transform.Translate(speed, 0, 0);
    }

}
