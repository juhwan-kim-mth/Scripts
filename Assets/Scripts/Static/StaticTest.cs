using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Bullets bullet1 = new Bullets();
        // Bullets.noOfBullets = 10;

        Bullets bullet2 = new Bullets();
        // Bullets.noOfBullets = 20;

        Bullets bullet3 = new Bullets();
        
        // print(Bullets.noOfBullets);
        //print(bullet2.noOfBullets);
        Bullets.ShowBullets();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Bullets
{
    public static int noOfBullets = 0;

    public Bullets()
    {
        noOfBullets++;
    }

    public static void ShowBullets()
    {
        Debug.Log("No of Bullets :" + noOfBullets);
    }
}