using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displacer : MonoBehaviour
{
    public float speed = 1.0f;
    

    void Start()
    {   
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(speed, 0, 0, ForceMode.Impulse);
    }
}
