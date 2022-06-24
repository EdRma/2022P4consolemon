using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolemon
{
    internal class Skill
    {
      int Damage = 60;
      int EnergyCost = 15;
      int Accuracy = 100;  
      string name = "dragon breath";
      elements element;



        internal void UseOn(Consolemon target, Consolemon caster)
        {
            caster.DepleteEnergy(EnergyCost);
            target.TakeDamage(Damage);
        }
        internal Skill()
        {

        }
        internal Skill(Skill copyFrom)
        {
            this.Damage = copyFrom.Damage;
            this.EnergyCost = copyFrom.EnergyCost;
            this.name = copyFrom.name;
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