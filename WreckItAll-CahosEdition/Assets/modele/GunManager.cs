using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GunManager
{

    /*private GameObject gunPrefab;
    private GunShooter gunShooter;

    public AGun gun;

    public void OnGunShoot(){
        if (gun.IsMagazineEmpty()){
            //Invoke(gun.reload(), 5.0f);
        }
        else{
            gun.shootBullet();
            gunShooter.shootBullet();
        }
    }

    // Start is called before the first frame update
    public GunManager()
    {
        //gun = new Gun(30);
        gunPrefab = (GameObject) Resources.Load("prefabs/Gun");
        var instPrefab = GameObject.Instantiate(gunPrefab, new Vector3(0, 3, 0), Quaternion.identity);
        gunShooter = instPrefab.GetComponent<GunShooter>();
        gunShooter.OnBulletShooted += OnGunShoot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
