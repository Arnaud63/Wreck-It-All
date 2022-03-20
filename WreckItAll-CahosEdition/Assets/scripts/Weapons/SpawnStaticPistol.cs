using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnStaticPistol : MonoBehaviour
{
    [Inject]
    private WeaponManager weaponGlueCode;
    [Inject]
    public IWeaponSpawner weaponSpawner;

    [SerializeField]
    private GameObject PistolPrefab;

    void Awake()
    {
        weaponGlueCode.SpawnWeapon(weaponSpawner, PistolPrefab, gameObject.transform);
        this.moveGunToFps();
        
    }

    private void moveGunToFps()
    {
        Vector3 localPos = this.gameObject.GetComponentInChildren<GunShooter>().gameObject.transform.localPosition;
        localPos.x = 0.48f;
        localPos.y = -1.526f;
        localPos.z = 0.11f;
        this.gameObject.GetComponentInChildren<GunShooter>().gameObject.transform.localPosition = localPos;
        this.gameObject.GetComponentInChildren<GunShooter>().gameObject.transform.Rotate(0, -183.709f, 0);
    } 
}
