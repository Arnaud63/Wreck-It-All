using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbCollisionController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponentInParent<RobotTouched>().OnCollisionFromChild(collision, this.gameObject.GetComponent<Rigidbody>());
    }
}
