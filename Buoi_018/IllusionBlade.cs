using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_018
{
    internal class IllusionBlade : Skill
    {
        public IllusionBlade()
        {
            name = "Kiem ao anh";
            basic_dmg = 30;
            power_scale = 1.8;
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
