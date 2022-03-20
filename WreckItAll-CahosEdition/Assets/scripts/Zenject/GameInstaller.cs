using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using ZenjectDemo.Source.Announcer;
using ZenjectDemo.Scripts.Game;

namespace ZenjectDemo.Scripts.Zenject
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IWorldAnnouncer>().To<DestroyAnnouncer>().AsSingle().NonLazy();
        }
    }
}

