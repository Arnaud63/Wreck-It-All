using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displacer : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * -speed * Time.fixedDeltaTime);
    }
}
