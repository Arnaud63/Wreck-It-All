using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooter : MonoBehaviour
{
    public GameObject bullet;

    public delegate void BulletShootedHandler();
    public event BulletShootedHandler OnBulletShooted;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update(){
        if (Input.GetButtonDown("Fire1")){
            OnBulletShooted?.Invoke();
        }
    }

    public void shootBullet(){
        var bulletPrefab = (GameObject) Resources.Load("prefabs/BulletPrefab");
        var bullet = GameObject.Instantiate(bulletPrefab, new Vector3(0, 3, 0), Quaternion.identity);
        Destroy(bullet, 2);
    }
}
