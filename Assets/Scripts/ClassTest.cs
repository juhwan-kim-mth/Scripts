using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Car myCar = new Car();
        myCar.speed = 10.5f;
        myCar.color = "Red";
        myCar.highestSpeed = 100;

        Car suzuki = new Car();
        suzuki.speed = 20.0f;
        suzuki.color = "Green";
        suzuki.highestSpeed = 150;

        myCar.CarSpeed();
        suzuki.CarSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
