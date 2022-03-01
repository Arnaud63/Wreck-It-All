using Zenject;
using UnityEngine;
using System.Collections;

public class InjecteurDeDependences : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<WeaponGlueCode>().AsSingle();
        Container.Bind<PistolSpawner>().AsTransient();
    }
}
