using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BulletCollisionner : MonoBehaviour
{
    [Inject]
    private WeaponManager weaponGlueCode;

    [Inject]
    private InjectedPrefabFactory injectedPrefabFactory;

    [SerializeField]
    private GameObject explodedPrefab;

    private void Awake()
    {
        if (explodedPrefab == null) throw new MissingComponentException("explodedPrefab is null");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (weaponGlueCode.ContainsGameObject(collision.collider.gameObject)) return;
        if (!weaponGlueCode.ContainsGameObject(gameObject)) return;
        var bulletBits = injectedPrefabFactory.InstantiateInjectedPrefab(
            explodedPrefab, gameObject.transform.position, Quaternion.identity);
        weaponGlueCode.DestroyLinkGameObjectIWeaoon(gameObject);
        Destroy(this.gameObject, 0.1f);
    }
}
