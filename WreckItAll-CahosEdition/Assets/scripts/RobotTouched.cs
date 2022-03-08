using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RobotTouched : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.ToggleAnimation();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
            this.OnTouched();
        }
    }

    public void OnTouched()
    {
        this.ToggleRagdoll();
    }
    
    private void ToggleRagdoll()
    {
        this.ChangeCollidersState(true);
        this.GetComponent<Animator>().enabled = false;
        this.GetComponent<animationStateController>().enabled = false;
        this.GetComponent<NavMeshAgent>().enabled = false;
        this.GetComponent<PlayerController>().enabled = false;
    }

    private void ToggleAnimation()
    {
        this.ChangeCollidersState(false);
        this.GetComponent<Animator>().enabled = true;
        this.GetComponent<animationStateController>().enabled = true;
        this.GetComponent<NavMeshAgent>().enabled = true;
        this.GetComponent<PlayerController>().enabled = true;
    }

    private void ChangeCollidersState(bool state)
    {
        Collider[] limbsColliders = this.gameObject.GetComponentsInChildren<Collider>();
        foreach(Collider collider in limbsColliders)
        {
            collider.enabled = state;
        }
    }
}
