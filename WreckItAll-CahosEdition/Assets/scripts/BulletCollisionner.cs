using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BulletCollisionner : MonoBehaviour
{
    [Inject]
    private WeaponManager weaponGlueCode;

    private void OnCollisionEnter(Collision collision)
    {
        weaponGlueCode.DestroyLinkGameObjectIWeaoon(gameObject);
        //effet de particule
        Destroy(this.gameObject);
    }
}
