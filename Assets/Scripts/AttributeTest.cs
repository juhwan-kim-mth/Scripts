using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class AttributeTest : MonoBehaviour
{
    // [SerializeField] private int speed;
    // [HideInInspector]
    [Range(0,20)]
    public int speed;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(speed*Time.deltaTime, 0, 0);
    }
}
