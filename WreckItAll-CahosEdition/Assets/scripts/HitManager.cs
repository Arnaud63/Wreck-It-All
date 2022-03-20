using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitManager : MonoBehaviour
{
    public GameObject destroyedVersion;

    private void OnMouseDown()
    {
        Debug.Log("Mouse Down");
        Instantiate(destroyedVersion, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Bullet")
        {
            Instantiate(destroyedVersion, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
            Destroy(gameObject);
        }
    }
}
