using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PistolSpawner : IWeaponSpawner
{
    [Inject]
    private InjectedPrefabFactory injectedPrefabFactory;
    public void SpawnWeapon(WeaponManager weaponGlueCode, GameObject prefab, Transform transform)
    {
        GameObject gun = injectedPrefabFactory.InstantiateInjectedPrefab(prefab,
            transform.position, transform.rotation);

        AGun gunData = new Pistol();
        weaponGlueCode.LinkGameObjectToIWeaoon(gun, gunData);
    }
}
