using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolemon
{
     internal class Consolemon
    {
        int Health = 420;
        int Attack = 394;
        int Defense = 317;
        int Energy = 155;
        string name = "garchchomp";

        List<Skill> Skills = new List<Skill>();

        public void TakeDamage(int Damage)
        {

            Health = -Damage;
        }

        public void DepleteEnergy(int energy)
        {
            Energy = -energy;
        }

        internal Consolemon()
        {

        }

        internal Consolemon(Consolemon copyFrom)
        {
            this.name = copyFrom.name;
            this.Health = copyFrom.Health;
            this.Energy = copyFrom.Energy;

            Attack = copyFrom.Attack;
            //[slash, dig, dragon breath, hyperbeam]

            for (int i = 0; i < copyFrom.Skills.Count; i++)
            {
                Skill copyFromThisSkill = copyFrom.Skills[i];
                Skill copy = new Skill(copyFromThisSkill);

                this.Skills.Add(copy);
            }
        }
    }

    internal class ConsoleMonArena
    {

    }


}