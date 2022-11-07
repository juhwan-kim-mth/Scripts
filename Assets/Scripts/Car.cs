using Unity.VisualScripting.FullSerializer;
using UnityEngine;
[System.Serializable]
public class Car
{
    public float speed;
    public string color;
    public int highestSpeed;

    // Constructor of the class
    public Car() 
    {
        Debug.Log("Car() called");
    }

    public Car(float speed)
    {
        this.speed = speed;
        Debug.Log("Car(float) is called");
    }

    public Car(float speed, string color)
    {
        this.speed = speed;
        this.color = color;
        Debug.Log("Car(float,string) is called");
    }
    
    // Methods
    void Move()
    {
        Debug.Log("Moving");
    }

    void ApplyBrake()
    {
        Debug.Log("Applying Brake");
    }

    public void CarSpeed()
    {
        Debug.Log(speed);
    }

    public void PrintCarDetails()
    {
        Debug.Log("Speed = " + speed);
        Debug.Log("Color = " + color);
        Debug.Log("Highest Speed = " + highestSpeed);
    }
}