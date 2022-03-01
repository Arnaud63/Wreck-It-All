using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private Transform EntityToFollow;
    private NavMeshAgent agent;

    void Start()
    {
        this.EntityToFollow = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
    }

    void FixedUpdate()
    {
        this.agent.SetDestination(EntityToFollow.position);
    }
}
