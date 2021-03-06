using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

/// <summary>
/// 
/// </summary>
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
        if (bulletPrefab == null) throw new MissingComponentException("Le pr?fab de bullet n'a pas ?t? renseign?");
    }

    public void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (!isInCoolDown)
            {
                weaponGlueCode.Shoot(gameObject, this);
            }  
        }
    }

    public void ShootBullet(){
        var bullet = injectedPrefabFactory.InstantiateInjectedPrefab(bulletPrefab,
            gameObject.transform.position,
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
