using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolemon
{
    class Consolemon
    {
        int health = 420;
        int attack = 394;
        int defense = 317;
        int energy = 155;
        string name = "garchchomp";

        List<Skill> skills = new List<Skill>();
        elements weakness;

        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            energy -= energy;
        }
    }
}
