using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject EntityToFollow;

    // Start is called before the first frame update
    void Start()
    {
        this.EntityToFollow = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("Follow", 2.0f, 0.001f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Follow() {
        Vector3 self_position = this.GetComponent<Transform>().position;
        Vector3 follow_force = new Vector3(this.EntityToFollow.GetComponent<Transform>().position.x - self_position.x,
                                            this.EntityToFollow.GetComponent<Transform>().position.y - self_position.y,
                                            this.EntityToFollow.GetComponent<Transform>().position.z - self_position.z);
        follow_force.x = follow_force.x > 10 ? 5 : follow_force.x;
        follow_force.y = follow_force.y > 10 ? 5 : follow_force.y;
        follow_force.z = follow_force.z > 10 ? 5 : follow_force.z;
        this.GetComponent<Rigidbody>().AddForce(follow_force);
    }
}
