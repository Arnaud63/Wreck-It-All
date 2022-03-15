using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : ISpawnWeapon
{
    private Dictionary<GameObject, IWeapon> linksGameObjectAndIWeapon;
    private GunManager gunManager;

    public WeaponManager()
    {
        linksGameObjectAndIWeapon = new Dictionary<GameObject, IWeapon>();
        gunManager = new GunManager();
    }

    public void LinkGameObjectToIWeaoon(GameObject gameObject, IWeapon weapon)
    {
        linksGameObjectAndIWeapon.Add(gameObject, weapon);
    }

    public void DestroyLinkGameObjectIWeaoon(GameObject gameObject)
    {
        linksGameObjectAndIWeapon.Remove(gameObject);
    }

    public bool ContainsGameObject(GameObject gameObject)
    {
        return linksGameObjectAndIWeapon.ContainsKey(gameObject);
    }

    public IWeapon GetWeapon(GameObject gameObject)
    {
        return linksGameObjectAndIWeapon[gameObject];
    }
    
    public void Shoot(GameObject weaponGameObject, GunShooter gunShooter)
    {
        if (!(linksGameObjectAndIWeapon.ContainsKey(weaponGameObject)))
            throw new KeyNotFoundException("This weapon has no model's instance linked !");
        //if (!typeof(AGun).IsInstanceOfType(linksBetweenGameObjectAndEnemy[weaponGameObject]))
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

    public void SpawnWeapon(IWeaponSpawner spawner, GameObject prefab, Transform transform)
    {
        spawner.SpawnWeapon(this, prefab, transform);
    }
}
