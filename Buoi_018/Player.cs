using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_018
{
    internal class Player
    {
        private List<Skill> player_skill;

        public Player()
        {
            this.player_skill = new List<Skill> { };
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin cho 5 ki nang cho nguoi choi: ");
            Skill s = null;

            s = new DestructedFlame();
            player_skill.Add(s);
            s = new SoaringWind();
            player_skill.Add(s);
            s = new GodThunder();
            player_skill.Add(s);
            s = new IllusionBlade();
            player_skill.Add(s);
            s = new DarkScythe();
            player_skill.Add(s);
        }

        public void Xuat()
        {
            Console.WriteLine("Thong tin cua 5 ki nang lan luot la:");
            foreach (Skill s in player_skill)
            {
                Console.WriteLine(s.Info() + " | " + s.RealDamage());
            }
            Console.WriteLine("\n");
            calculateFullComboMana();
            Console.WriteLine("\n");
            rankingSkillEfficiency();

        }

        public void calculateFullComboMana()
        {
            Console.WriteLine("Tong Mana can su dung: ");
            Console.WriteLine(player_skill.Sum(s => s.ManaNeed));
        }

        public void rankingSkillEfficiency()
        {
            Console.WriteLine("Danh sach sap xep hieu suat cua cac skill");

            var list = player_skill.OrderBy(s => (s.TrueDamage/s.Mana_per_dmg));

            foreach (Skill s in list)
            {
                Console.WriteLine(s.Info() + " | " + s.RealDamage());
            }
        }
    }
}
