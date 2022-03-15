using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class AKSpawner : IWeaponSpawner
{
    //Je peux inject car je l'instancie dans l'injection de dependance
    [Inject]
    private InjectedPrefabFactory injectedPrefabFactory;
    public void SpawnWeapon(WeaponManager weaponGlueCode, GameObject prefab, Transform transform)
    {
        //Faire factory enft unity instancie donc ZenJect ne peut pas injecter
        //Solition: injecter 
        
        GameObject gun = injectedPrefabFactory.InstantiateInjectedPrefab(prefab,
            transform.position, transform.rotation);
        
        AGun gunData = new AK();
        weaponGlueCode.LinkGameObjectToIWeaoon(gun, gunData);
    }
}
