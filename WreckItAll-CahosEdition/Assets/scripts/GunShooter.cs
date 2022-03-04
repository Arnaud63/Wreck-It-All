using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GunShooter : MonoBehaviour, IGunCoolDown
{
    [Inject]
    private WeaponManager weaponGlueCode;

    [Inject]
    private InjectedPrefabFactory injectedPrefabFactory;

    private bool isInCoolDown = false;

    [SerializeField]
    private GameObject bulletPrefab;

    private void Awake()
    {
        if (bulletPrefab == null) throw new MissingComponentException("Le préfab de bullet n'a pas été renseigné");
    }

    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!isInCoolDown)
            {
                weaponGlueCode.Shoot(this.gameObject, this);
            }  
        }
    }

    public void ShootBullet(){
        var bullet = injectedPrefabFactory.InstantiateInjectedPrefab(bulletPrefab,
            gameObject.transform.localPosition,
            gameObject.transform.rotation);
        weaponGlueCode.LinkGameObjectToIWeaoon(bullet, new Bullet());
        Destroy(bullet, 5);
    }

    public void StartCoolDown(float delay)
    {
        isInCoolDown = true;
        WaitDelay(delay);
    }

    public void EndCoolDown()
    {
        isInCoolDown = false;
    }

    public void WaitDelay(float delay)
    {
        Invoke("EndCoolDown", delay);
    }
}
