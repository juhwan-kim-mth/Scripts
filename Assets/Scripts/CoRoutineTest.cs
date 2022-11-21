using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutineTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine("Test");
        //Test2();
        StartCoroutine("Test3", 4);
        for (int i = 0; i < 5; i++)
        {
            print("Start()");
        }
        // StopCoroutine("Test3");
    }

    // Update is called once per frame

    IEnumerator Test()
    {
        print("CoRoutine starts");
        yield return new WaitForSeconds(2f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(2f);
        GetComponent<Renderer>().material.color = Color.green;
        print("CoRoutine ends");

    }

    void Test2()
    {
        for(int i=0;i<5;i++)
        {
            print("Test2()");
        }
    }

    IEnumerator Test3(int num)
    {
        for (int i = 0; i < num; i++)
        {
            print("Test3()");
            yield return null;
        }
    }
}
