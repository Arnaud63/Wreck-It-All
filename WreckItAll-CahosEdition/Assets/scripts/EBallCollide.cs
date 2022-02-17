using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBallCollide : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "player")
        {

        }
    }
}
