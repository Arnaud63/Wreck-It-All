using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GunManager
{
    private Dictionary<GameObject, AGun> gunModelLinks;//def le hashcode

    public GunManager()
    {
        gunModelLinks = new Dictionary<GameObject, AGun>();
    }

    public void LinkGameObjectWithGunModel(GameObject gameObject, AGun gun)
    {
        gunModelLinks.Add(gameObject, gun);
    }

    public void shoot(GameObject gunGameObject, IShooter shooter)
    {
        if (!(gunModelLinks.ContainsKey(gunGameObject))) 
            throw new KeyNotFoundException("Ce gun n'a pas de modèle métier lié");
        AGun gunModel = gunModelLinks[gunGameObject];
        if (gunModel.CanShoot)
        {
            if (gunModel.IsMagazineEmpty())
            {
                gunModel.CanShoot = false;
                shooter.WaitDelay(gunModel.Reload());
            }
            else
            {
                gunModel.DecreaseNbBulletInMagazine();
                shooter.shootBullet();
                gunModel.CanShoot = false;
                shooter.WaitDelay(gunModel.FireDelay);
            }
        }
    }

    public void AllowShoot(GameObject gunGameObject)
    {
        if (!(gunModelLinks.ContainsKey(gunGameObject)))
            throw new KeyNotFoundException("Ce gun n'a pas de modèle métier lié");
        gunModelLinks[gunGameObject].CanShoot = true;
    }
}
