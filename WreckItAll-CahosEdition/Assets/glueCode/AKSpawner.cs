using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class AKSpawner : IWeaponSpawner
{
    //Je peux inject car je l'instancie dans l'injection de dependance
    [Inject]
    private InjectedPrefabFactory injectedPrefabFactory;
    public void SpawnWeapon(WeaponManager weaponGlueCode, GameObject prefab, float spawnX, float spawnY, float spawnZ)
    {
        //Faire factory enft unity instancie donc ZenJect ne peut pas injecter
        //Solition: injecter 
        
        GameObject gun = injectedPrefabFactory.InstantiateInjectedPrefab(prefab,
            new Vector3(spawnX, spawnY, spawnZ));
        
        AGun gunData = new AK();
        weaponGlueCode.LinkGameObjectToIWeaoon(gun, gunData);
    }
}
