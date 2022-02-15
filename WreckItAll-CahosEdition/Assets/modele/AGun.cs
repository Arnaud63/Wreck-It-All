using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AGun : IWeapon
{
    protected int magazine;
    protected int magazineSize;
    protected float reloadingTime;

    protected AGun(int magazineSize, int reloadingTime){
        this.magazineSize = 30;
        magazine = magazineSize;
        this.reloadingTime = reloadingTime;
        Debug.Log("Arme instanciée");
    }

    public bool IsMagazineEmpty(){
        return magazine == 0;
    }

    public void Reload(){
        magazine = magazineSize;
        Debug.Log("realod");
    }

    public void DecreaseNbBulletInMagazine(){
        if (IsMagazineEmpty()) return;
        magazine = magazine - 1;
    }
}
