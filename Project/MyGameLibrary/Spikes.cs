using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{
    public class Spikes
    {
        public Vector2 Position { get; set; }
        public Collider Collider { get; set; }

        public int damage_value { get; set; }



        public Spikes(Vector2 initPos, Collider collider, int damage)
        {
            Position = initPos;
            Collider = collider;
            damage_value = damage;
        }
    }
}
