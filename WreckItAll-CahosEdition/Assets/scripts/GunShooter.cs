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
}
