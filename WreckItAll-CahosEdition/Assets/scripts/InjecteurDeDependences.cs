using Zenject;
using UnityEngine;
using System.Collections;

public class InjecteurDeDependences : MonoInstaller
{
    public override void InstallBindings() 
    {
        Container.BindInstance(new InjectedPrefabFactory(Container));
        Container.Bind<IWeaponSpawner>().To<AKSpawner>().AsTransient().WhenInjectedInto<SpawnAK>();
        Container.Bind<IWeaponSpawner>().To<SwordSpawner>().AsTransient().WhenInjectedInto<SpawnSword>();
        Container.Bind<WeaponManager>().AsSingle();
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
