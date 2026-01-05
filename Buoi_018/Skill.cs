using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_018
{
    internal class Skill
    {
        protected string name;
        protected double basic_dmg;
        protected double power_scale;
        protected double mana_per_dmg;

        public Skill()
        {
            basic_dmg = 0;
            power_scale = 0;
            mana_per_dmg = 0;
        }

        public Skill(double basic_dmg, double power_scale, double mana_per_dmg)
        {
            this.basic_dmg = basic_dmg;
            this.power_scale = power_scale;
            this.mana_per_dmg = mana_per_dmg;
        }

        public double Basic_dmg => basic_dmg;
        public double Power_scale => power_scale;
        public double Mana_per_dmg => mana_per_dmg;

        public virtual string Info()
        {
            return $"skill's name: {name} | basic damage: {basic_dmg} | power scale: {power_scale} | mana per damage: {mana_per_dmg}";
        }

        public double TrueDamage => basic_dmg * power_scale;
        public double ManaNeed => TrueDamage * mana_per_dmg;

        public virtual string RealDamage()
        {
            return $"True Damage: {TrueDamage} | Mana Need: {ManaNeed}";
        }

    }
}
