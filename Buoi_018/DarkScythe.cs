using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_018
{
    internal class DarkScythe : Skill
    {
        public DarkScythe()
        {
            name = "Luoi hai bong den";
            basic_dmg = 45;
            power_scale = 2.5;
            mana_per_dmg = 8;
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
