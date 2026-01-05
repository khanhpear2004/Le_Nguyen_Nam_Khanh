using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_018
{
    internal class DestructedFlame : Skill
    {
        public DestructedFlame()
        {
            name = "Lua dia nguc";
            basic_dmg = 40;
            power_scale = 1.5;
            mana_per_dmg = 5;
        }

        public override string Info()
        {
            return base.Info();
        }

        public override string RealDamage()
        {
            return base.RealDamage();
        }
    }
}
