using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class StaticPistolSpawner : IWeaponSpawner
{
    [Inject]
    private InjectedPrefabFactory injectedPrefabFactory;
    public void SpawnWeapon(WeaponManager weaponGlueCode, GameObject prefab, Transform transform)
    {
        //GameObject gun = injectedPrefabFactory.InstantiateInjectedPrefab(prefab,
            //new Vector3(0.369f, -1.48f, 0.232f), Quaternion.Euler(0f, -169f, 0f), transform);
        GameObject gun = injectedPrefabFactory.InstantiateInjectedPrefab(prefab,
            transform.position,transform.rotation, transform);

        AGun gunData = new Pistol();
        weaponGlueCode.LinkGameObjectToIWeaoon(gun, gunData);
    }
}
