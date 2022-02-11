using Zenject;
using UnityEngine;
using System.Collections;

public class InjecteurDeDependences : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<string>().FromInstance("Hello World!");
        Container.Bind<Greeter>().AsSingle().NonLazy();
        Container.Bind<Gun>().FromInstance(new Gun(30));
    }
}

public class Greeter
{
    public Greeter(string message)
    {
        Debug.Log(message);
    }
}