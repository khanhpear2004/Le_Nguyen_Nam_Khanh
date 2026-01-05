using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_018
{
    internal class SoaringWind : Skill
    {
        public SoaringWind()
        {
            name = "Gio xuyen tam";
            basic_dmg = 25;
            power_scale = 2.0;
            mana_per_dmg = 6;
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
