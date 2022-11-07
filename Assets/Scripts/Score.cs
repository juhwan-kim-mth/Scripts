using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    private int point;
    private int lives;

    public int Point
    {
        get
        {
            return point;
        }
        set
        {
            if (value > 5 && value < 10)
            {
                point = value;
            }
            printPoint();
            
        }
    }

    public int Lives { get; set; }

    void printPoint()
    {
        Debug.Log(point);
    }
}
