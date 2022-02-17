using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.modele
{
    public abstract class Enemy
    {
        public string Name { get; set; }
        public float Pv { get; set; }
        public float Vitesse { get; set; }

        public Enemy(string name, float pv, float vitesse)
        {
            Name = name;
            Pv = pv;
            Vitesse = vitesse;
        }
    }
}
