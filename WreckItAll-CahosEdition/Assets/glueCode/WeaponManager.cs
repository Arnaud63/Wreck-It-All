using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : AWeaponGlueCode, ISpawnWeapon
{
    private GunManager gunManager;
    public WeaponManager()
    {
        gunManager = new GunManager();
    }
    public void Shoot(GameObject weaponGameObject, GunShooter gunShooter)
    {
        if (!(linksGameObjectAndIWeapon.ContainsKey(weaponGameObject)))
            throw new KeyNotFoundException("This weapon has no model's instance linked !");
        //if (!typeof(AGun).IsInstanceOfType(linksGameObjectAndIWeapon[weaponGameObject]))
        if (linksGameObjectAndIWeapon[weaponGameObject] is AGun gun)
        {
            if (gunManager.IsMagazineEmpty(gun))
            {
                gunManager.Reload(gun);
                gunShooter.StartCoolDown(gun.ReloadingTime);
                return;
            }
            else
            {
                gunManager.Shoot(gun);
                gunShooter.ShootBullet();
                gunShooter.StartCoolDown(gun.FireDelay);
            }
        }
    }

    public void SpawnWeapon(IWeaponSpawner spawner, GameObject prefab, float spawnX, float spawnY, float spawnZ)
    {
        spawner.SpawnWeapon(this, prefab, spawnX, spawnY, spawnZ);
    }
}