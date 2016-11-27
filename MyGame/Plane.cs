using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Plane : Hero

    {

        public override void Skill2(List<Hero> Targets)
        {
            if (this.Ap >= 30)
            {
                this.Ap = -30;
                foreach (Hero H in Targets)
                {
                    H.Ap += 90;
                    if(H.Maxap <= H.Ap)
                    {
                        H.Ap = H.Maxap;
                    }
                }

            }
        }
        public override void Skill1()
        {
            if (Ap >= 90)
            {
                Target.Hp = Target.Hp - 900;
                this.Ap -= 90;
            }
            else
            {
                Attack();
            }
          
        }

        public Plane(int maxhp, int hp, int maxap, int ap, int dmg, int ex, bool team, string contr, int hpRegen, bool Death)
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
