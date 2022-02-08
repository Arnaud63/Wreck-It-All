using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gunPrefab;
    private Gun gun;

    public void OnGunShoot(){
        
    }

    // Start is called before the first frame update
    void Start()
    {
        var gun = Instantiate(gunPrefab, new Vector, rot);
        var gunShooter = gun.getCompenent<GunShooter>();
        gunShooter.OnBulletShooted += OnGunShoot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
