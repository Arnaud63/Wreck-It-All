using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.modele;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //base.InstallBindings();
        Container.Bind<EBall>();
    }
}
