using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitted : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sign = 1;
        foreach(Transform child in transform)
        {
            sign = sign * -1;
            child.GetComponent<Rigidbody>().AddForce(new Vector3(500*sign, 500* sign, 500*sign));
        }
        Destroy(gameObject, 5f);
    }
}
