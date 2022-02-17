using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class PistolSpawner : IWeaponSpawner
{
    [Inject]
    public GunManager gunManager;
    public void SpawnWeapon(GameObject prefab, float spawnX, float spawnY, float spawnZ)
    {
        if (prefab == null) throw new MissingComponentException("Le pr�fab de gun n'a pas �t� renseign�");
        var tmp = GameObject.Instantiate(prefab, new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity);
        tmp.GetComponent<GunShooter>().gunManager = gunManager;
        gunManager.LinkGameObjectWithGunModel(tmp, new Pistol());
    }
}
