using Zenject;
using UnityEngine;
using System.Collections;

public class InjecteurDeDependences : MonoInstaller
{
    public override void InstallBindings()
    {
        /*Container.Bind<Gun>().AsSingle().OnInstantiated<Gun>((ctx, gun) =>{
            gun.SetMagazineSize(30);
            gun.SetMagazine(gun.GetMagazineSize());
        });*/
        Container.Bind<string>().FromInstance("Hello World!");
        Container.Bind<Greeter>().AsSingle().NonLazy();

        Container.Bind<Pistol>().AsTransient();
    }
}

public class Greeter
{
    public Greeter(string message)
    {
        Debug.Log(message);
    }
}