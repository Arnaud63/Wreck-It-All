using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZenjectDemo.Source.Announcer
{
   public class PeaceAnnouncer : IWorldAnnouncer
    {
        public PeaceAnnouncer()
        {
            Debug.Log("<PeaceAnnouncer initialized !>");
        }

        /// <inheritdoc/>
        public void WriteWorldAnnouncement() {
            Debug.Log("Peace has been restored all around the world. Kirbo, as Poyo as he is, juste ate the Chpotatoe king !");
        }
    }
}
