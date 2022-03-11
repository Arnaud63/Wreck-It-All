using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Zenject;

public class RobotTouched : MonoBehaviour
{
    [Inject]
    private EnemysManager enemysManager;
    [Inject]
    private WeaponManager weaponManager;

    private static int DESPAWN_TIME = 10;

    // Start is called before the first frame update
    void Start()
    {
        this.ToggleAnimation();
        ChangeIsKinematicState(true);
        ChangeCollisionDetectionMode(CollisionDetectionMode.ContinuousSpeculative);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (enemysManager.ContainsGameObject(collision.collider.gameObject.transform.root.gameObject)) return;
        //Devrait y avoir un test si c'est une IWeapon mais ça ne fonctionne pas, tout ce qui entre en
        //collision avec l'ennemy est considéré comme pas une IWeapon
        enemysManager.DestroyLinkGameObjectIEnemy(collision.collider.gameObject);
        OnTouched();
    }

    // Update is called once per frame
    void Update()
    {
        //ONLY FOR TEST PURPOSE
        if(Input.GetKey("d"))
        {
            this.OnTouched();
        }
    }

    public void OnTouched()
    {
        this.ToggleRagdoll();
        Destroy(this.gameObject, DESPAWN_TIME);
    }
    
    private void ToggleRagdoll()
    {
        //this.ChangeCollidersState(true);
        this.GetComponent<Animator>().enabled = false;
        ChangeIsKinematicState(false);
        this.GetComponent<animationStateController>().enabled = false;
        this.GetComponent<NavMeshAgent>().enabled = false;
        this.GetComponent<NavMeshAgentController>().enabled = false;
    }

    private void ToggleAnimation()
    {
        //this.ChangeCollidersState(false);
        this.GetComponent<Animator>().enabled = true;
        ChangeIsKinematicState(true);
        this.GetComponent<animationStateController>().enabled = true;
        this.GetComponent<NavMeshAgent>().enabled = true;
        this.GetComponent<NavMeshAgentController>().enabled = true;
    }

    private void ChangeCollidersState(bool state)
    {
        Collider[] limbsColliders = this.gameObject.GetComponentsInChildren<Collider>();
        foreach(Collider collider in limbsColliders)
        {
            collider.enabled = state;
        }
    }

    private void ChangeIsKinematicState(bool state)
    {
        foreach (Rigidbody rb in gameObject.GetComponentsInChildren<Rigidbody>())
        {
            rb.isKinematic = state;
            //rb.collisionDetectionMode = state ?  CollisionDetectionMode.ContinuousSpeculative : CollisionDetectionMode.D;
        }
    }

    private void ChangeCollisionDetectionMode(CollisionDetectionMode detect_mode)
    {
        foreach (Rigidbody rb in gameObject.GetComponentsInChildren<Rigidbody>())
        {
            rb.collisionDetectionMode = detect_mode;
        }
    }
}
