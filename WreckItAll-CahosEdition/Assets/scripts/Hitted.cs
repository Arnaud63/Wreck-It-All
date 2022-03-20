using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Hitted : MonoBehaviour
{
    [Inject]
    WeaponManager weaponGlueCode;

    // Start is called before the first frame update
    void Start()
    {
        int sign = 1;
        foreach(Transform child in transform)
        {
            sign = sign * -1;
            child.GetComponent<Rigidbody>().AddForce(new Vector3(500*sign, 500* sign, 500*sign));
        }
        if (weaponGlueCode.ContainsGameObject(gameObject))
        {
            Invoke("Delink", 5f);
        }
        else Destroy(gameObject, 5f);
    }

    void Delink()
    {
        weaponGlueCode.DestroyLinkGameObjectIWeaoon(gameObject);
        Destroy(gameObject);
    }
}
