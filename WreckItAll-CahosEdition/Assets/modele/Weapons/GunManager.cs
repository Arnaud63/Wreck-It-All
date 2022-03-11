using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GunManager
{
    public bool CanShoot(AGun gun)
    {
        return gun.CanShoot;
    }

    public bool IsMagazineEmpty(AGun gun)
    {
        return gun.IsMagazineEmpty();
    }

    public void Reload(AGun gun)
    {
        gun.Reload();
    }

    public void Shoot(AGun gun)
    {
        gun.DecreaseNbBulletInMagazine();
    }
}
