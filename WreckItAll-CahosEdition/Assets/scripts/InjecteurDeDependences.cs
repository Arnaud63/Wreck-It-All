using Zenject;
using UnityEngine;
using System.Collections;

public class InjecteurDeDependences : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<GunManager>().AsSingle(); //peut etre injecte 1 fois
        Container.Bind<PistolSpawner>().AsTransient();
    }
}
