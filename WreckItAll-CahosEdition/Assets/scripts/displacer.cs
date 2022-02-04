using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displacer : MonoBehaviour
{
    public float thrust = 1.0f;
    

    void Start()
    {   
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(0, thrust, 0, ForceMode.Impulse);
    }
}
