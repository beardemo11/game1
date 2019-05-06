using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Player : Creature
    {

        private int Exp = 0;

        public int getlevel()
        {
            return this.Level;
        }

        public class 騎士 : Player
        {
            public 騎士()
            {
                this.Hp = 200;
                this.Level = 1;
                this.Name = "騎士";
                this.Power = 10;
            }

            public int AddExp(int MonsterExp)
            {
                Exp += MonsterExp;
                if (Exp > 10)
                    Uplevel();
                return Exp;
            }
            public void Uplevel()
            {
                Exp -= 10;
                this.Hp += 50;
                this.Level += 1;
            }


        }



    }
}
