using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun
{
    private int magazine;
    private int magazineSize;

    public Gun(int magazineSize){
        this.magazineSize = 30;
        magazine = magazineSize;
        Debug.Log("Arme instanciée");
    }

    public bool IsMagazineEmpty(){
        return magazine == 0;
    }

    public void reload(){
        magazine = magazineSize;
    }

    public void shootBullet(){
        if (IsMagazineEmpty()) return;
        magazine = magazine - 1;
    }
}
