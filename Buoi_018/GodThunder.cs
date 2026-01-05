using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_018
{
    internal class GodThunder : Skill
    {
        public GodThunder()
        {
            name = "Song set than";
            basic_dmg = 35;
            power_scale = 2.2;
            mana_per_dmg = 7;
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
