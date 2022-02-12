using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementStrength = 1f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void FixedUpdate(){
        if( Input.GetKey("z")){
            rb.AddForce(MovementStrength,0,0,ForceMode.VelocityChange);
        }
        if( Input.GetKey("s")){
            rb.AddForce(-MovementStrength,0,0,ForceMode.VelocityChange);
        }
        if( Input.GetKey("q")){
            rb.AddForce(0,0,MovementStrength,ForceMode.VelocityChange);
        }
        if( Input.GetKey("d")){
            rb.AddForce(0,0,-MovementStrength,ForceMode.VelocityChange);
        }
        if(rb.position.y <= -10f){
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
