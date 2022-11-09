using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected void Attack()
    {
        Debug.Log("Enemy attack");
        GetComponent<Renderer>().material.color = Color.red;
        
    }
}

