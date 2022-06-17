using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolemon
{
    class Skill
    {
      int damage = 60;
      int EnergyCost = 15;
      int accuracy = 100;  
      string name = "dragon breath";
      elements element;



        internal void UseOn(Consolemon target, Consolemon caster)
        {
            caster.DepleteEnergy(EnergyCost);
            target.TakeDamage(damage);
        }

    }
    enum elements
    {
        steel,
        fire,
        ground,
        dragon
    }
}