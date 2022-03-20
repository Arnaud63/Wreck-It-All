using Zenject;
using UnityEngine;
using System.Collections;

public class InjecteurDeDependences : MonoInstaller
{
    public override void InstallBindings() 
    {
        Container.BindInstance(new InjectedPrefabFactory(Container));
        Container.Bind<WeaponManager>().AsSingle();
        Container.Bind<EnemysManager>().AsSingle();
        Container.Bind<IWeaponSpawner>().To<AKSpawner>().AsTransient().WhenInjectedInto<SpawnAK>();
        Container.Bind<IWeaponSpawner>().To<SwordSpawner>().AsTransient().WhenInjectedInto<SpawnSword>();
        Container.Bind<IWeaponSpawner>().To<SpearSpawner>().AsTransient().WhenInjectedInto<SpawnSpear>();
        Container.Bind<IWeaponSpawner>().To<PistolSpawner>().AsTransient().WhenInjectedInto<SpawnPistol>();
        Container.Bind<IWeaponSpawner>().To<StaticPistolSpawner>().AsTransient().WhenInjectedInto<SpawnStaticPistol>();
    }
}

public class InjectedPrefabFactory
{
    private readonly DiContainer _container;
    public InjectedPrefabFactory(DiContainer container)
    {
        _container = container;
    }

    public GameObject InstantiateInjectedPrefab(GameObject prefab, Vector3 pos,
        Quaternion rot = default, Transform parent = null)
    {
        if (rot == default) rot = Quaternion.identity;
        return _container.InstantiatePrefab(prefab, pos, rot, parent);
    }
}
