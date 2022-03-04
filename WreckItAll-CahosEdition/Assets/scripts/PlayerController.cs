using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private Transform EntityToFollow;
    private NavMeshAgent agent;
    private Animator playerAnimator;

    void Start()
    {
        this.EntityToFollow = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        this.playerAnimator = this.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    void FixedUpdate()
    {
        this.agent.SetDestination(EntityToFollow.position);
        if (agent.velocity != Vector3.zero)
        {
            this.playerAnimator.SetBool("isWalking", true);
        }
        else
        {
            this.playerAnimator.SetBool("isWalking", false);
        }
        if(agent.remainingDistance <= agent.stoppingDistance)
        {
            this.transform.LookAt(this.EntityToFollow);
        }
    }
}
