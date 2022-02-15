using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AGun : IWeapon
{
    protected int magazine;
    protected int magazineSize;
    protected float reloadingTime;
    public float FireDelay {
        get {
            return fireDelay;
        }
    }
    protected float fireDelay;
    public bool CanShoot
    {
        get
        {
            return canShoot;
        }
        set
        {
            canShoot = value;
        }
    }
    private bool canShoot;

    protected AGun(int magazineSize, float reloadingTime, float fireDelay){
        this.magazineSize = 30;
        magazine = magazineSize;
        this.reloadingTime = reloadingTime;
        canShoot = true;
        Debug.Log("Arme instanciée");
    }

    public bool IsMagazineEmpty(){
        return magazine == 0;
    }

    public float Reload(){
        magazine = magazineSize;
        return reloadingTime;
    }

    public void DecreaseNbBulletInMagazine(){
        if (IsMagazineEmpty()) return;
        magazine = magazine - 1;
    }
}
