using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BulletCollisionner : MonoBehaviour
{
    [Inject]
    private WeaponManager weaponGlueCode;

    [SerializeField]
    private GameObject explodedPrefab;

    private void Awake()
    {
        if (explodedPrefab == null) throw new MissingComponentException("explodedPrefab is null");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (weaponGlueCode.ContainsGameObject(collision.collider.gameObject)) return;
        Debug.Log("Collision");
        weaponGlueCode.DestroyLinkGameObjectIWeaoon(gameObject);
        //effet de particule
        Instantiate(explodedPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
