using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentController : MonoBehaviour
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
        if (agent.velocity.normalized.magnitude > 0.3)
        {
            this.playerAnimator.SetInteger("CombatMoves", 0);
            this.playerAnimator.SetBool("isFighting", false);
            this.playerAnimator.SetBool("isWalking", true); 
        }
        else
        {
            this.playerAnimator.SetBool("isWalking", false);
            this.playerAnimator.SetBool("isFighting", true);
            if (agent.remainingDistance > agent.stoppingDistance)
            {
                this.playerAnimator.SetInteger("CombatMoves", 0);
            }
            else
            {
                this.playerAnimator.SetInteger("CombatMoves", Random.Range(1, 5));
                this.transform.LookAt(this.EntityToFollow);
            }           
        }
    }
}

