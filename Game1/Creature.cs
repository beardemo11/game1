using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
   public abstract class Creature
    {
        public int Hp;

        public int Power;

        public int Exp;

        public string Name;

        public int Level;

        public int GetHP()
        {
            return Hp;
        }

        public void Attack(Creature target)
        {
            var AttackValue = RandomAttackValue();
            target.injured(AttackValue);

        }

        public void injured(int AttackValue)
        {
            this.Hp -= AttackValue;

            if (this.Hp <= 0)
                IsDead();

        }

        public int RandomAttackValue()
        {
            Random random = new Random();

            return random.Next((Power * Level) / 2, Power * Level);
        }
        public string  IsDead()
        {
            return "你已經死亡!";
        }

    }
}
