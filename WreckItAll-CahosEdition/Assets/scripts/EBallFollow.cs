using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.modele;
using Zenject;

public class EBallFollow : MonoBehaviour
{
    public EBall eball = new EBall("goomba");
    public GameObject EntityToFollow;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.eball.Name);
        Destroy(GetComponent<GameObject>(), 5);
        this.EntityToFollow = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("Follow", 0.0f, 0.5f);
    }

    void Follow()
    {
        Vector3 self_position = this.GetComponent<Transform>().position;
        Vector3 follow_force = new Vector3(this.EntityToFollow.GetComponent<Transform>().position.x - self_position.x,
                                            this.EntityToFollow.GetComponent<Transform>().position.y - self_position.y,
                                            this.EntityToFollow.GetComponent<Transform>().position.z - self_position.z);
        follow_force.Normalize();
        follow_force = follow_force * eball.Vitesse;
        this.GetComponent<Rigidbody>().AddForce(follow_force, ForceMode.VelocityChange);
    }
}
