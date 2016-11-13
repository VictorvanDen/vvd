using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Ship : Hero
    {
       
        public override void Skill2(List<Hero> Targets)
        {
            
        }
        public override void Skill1()
        {
            if(this.Ap <= 10)
            {
                Target.Hp = Target.Hp - this.Dmg - 70;
                this.Ap -= 10;
            }
            
        }

        public Ship(int maxhp, int hp, int maxap, int ap, int dmg, int ex, bool team, string contr, int hpRegen, bool Death)
        {
            this.Maxhp = maxhp;
            this.Hp = hp;
            this.Maxap = maxap;
            this.Ap = ap;
            this.Dmg = dmg;
            this.Ex = ex;
            this.Maxap = maxap;
            this.Team = team;
            this.Maxhp = maxhp;
            this.Contr = contr;
            this.Death = Death;
            this.HpRegen = hpRegen;
        }
    }
}
