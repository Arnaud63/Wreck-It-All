using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RobotTouched : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
        this.GetComponent<Animator>().enabled = false;
        this.GetComponent<animationStateController>().enabled = false;
        this.GetComponent<NavMeshAgent>().enabled = false;
        this.GetComponent<PlayerController>().enabled = false;
    }
}
