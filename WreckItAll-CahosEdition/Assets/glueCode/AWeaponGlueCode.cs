using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AWeaponGlueCode
{
    protected Dictionary<GameObject, IWeapon> linksGameObjectAndIWeapon;//def le hashcode

    protected AWeaponGlueCode()
    {
        linksGameObjectAndIWeapon = new Dictionary<GameObject, IWeapon>();
    }

    public void LinkGameObjectToIWeaoon(GameObject gameObject, IWeapon weapon)
    {
        linksGameObjectAndIWeapon.Add(gameObject, weapon);
    }

    public void DestroyLinkGameObjectIWeaoon(GameObject gameObject)
    {
        linksGameObjectAndIWeapon.Remove(gameObject);
    }

    public bool ContainsGameObject(GameObject gameObject)
    {
        return linksGameObjectAndIWeapon.ContainsKey(gameObject);
    }
}
