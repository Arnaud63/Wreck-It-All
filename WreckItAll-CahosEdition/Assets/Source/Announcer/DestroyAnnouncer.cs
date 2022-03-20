using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZenjectDemo.Source.Announcer
{
    public class DestroyAnnouncer : IWorldAnnouncer
    {
        public DestroyAnnouncer()
        {
            Debug.Log("<DestroyAnnouncer initialized !>");
        }

        /// <inheritdoc/>
        public void WriteWorldAnnouncement() {
            Debug.Log("WORLD IS GONNA BE DESTROYED ! The mad Chpotatoe king woke up and decided to bake every inhabitants of the world !");
        }
    }
}