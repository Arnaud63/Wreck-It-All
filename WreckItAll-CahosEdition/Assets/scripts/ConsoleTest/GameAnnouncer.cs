using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenjectDemo.Source.Announcer;
using Zenject;

namespace ZenjectDemo.Scripts.Game
{
    public class GameAnnouncer : MonoBehaviour
    {
        private IWorldAnnouncer m_worldAnnouncerByMethodInjection;

        [Inject]
        private IWorldAnnouncer m_worldAnnouncerByFieldInjection;

        [Inject]
        public IWorldAnnouncer m_worldAnnouncerByPropertyInjection { get; private set;}

        [Inject]
        private void Construct(IWorldAnnouncer worldAnnouncer)
        {
            m_worldAnnouncerByMethodInjection = worldAnnouncer;
        }

        void Start()
        {
            m_worldAnnouncerByMethodInjection.WriteWorldAnnouncement();
            m_worldAnnouncerByFieldInjection.WriteWorldAnnouncement();
            m_worldAnnouncerByPropertyInjection.WriteWorldAnnouncement();
        }
    }
}
