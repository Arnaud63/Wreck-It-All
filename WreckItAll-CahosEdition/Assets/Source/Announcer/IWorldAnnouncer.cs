using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZenjectDemo.Source.Announcer
{
    public interface IWorldAnnouncer
    {
        /// <summary>
        /// Simply write a world announcement.
        /// </summary>
        void WriteWorldAnnouncement();
    }
}