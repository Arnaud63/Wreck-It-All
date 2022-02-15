using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GunShooter : MonoBehaviour, IShooter
{
    [SerializeField]
    private GameObject bulletPrefab;

    //[Inject]
    public GunManager gunManager { get; set; }

    private void Awake()
    {
        if (bulletPrefab == null) throw new MissingComponentException("Le préfab de bullet n'a pas été renseigné");
    }

    public void Update(){
        if (Input.GetButtonDown("Fire1")){
            gunManager.shoot(this.gameObject, this);
        }
    }

    public void WaitDelay(float delay)
    {
        Invoke("AllowShootCall", delay);
    }

    public void AllowShootCall()
    {
        gunManager.AllowShoot(this.gameObject);
    }

    public void shootBullet(){
        Debug.Log("tire");
        var bullet = GameObject.Instantiate(bulletPrefab,
            this.gameObject.transform.position,
            this.gameObject.transform.rotation);
        Destroy(bullet, 5);
    }
}
