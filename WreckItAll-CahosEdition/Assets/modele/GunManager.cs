using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager
{
    private GameObject gunPrefab;
    private Gun gun;

    public void OnGunShoot(){
        
    }

    // Start is called before the first frame update
    public GunManager()
    {
        gunPrefab = (GameObject) Resources.Load("prefabs/Gun");
        var gun = GameObject.Instantiate(gunPrefab, new Vector3(0, 3, 0), Quaternion.identity);
        var gunShooter = gun.GetComponent<GunShooter>();
        gunShooter.OnBulletShooted += OnGunShoot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
