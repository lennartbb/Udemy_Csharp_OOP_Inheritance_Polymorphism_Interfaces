using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    abstract class Character
    {
        protected Character(int health)
        {
            Health = health;
        }
        public virtual int Health { get; set; }

        public virtual AttackResult Attack(Character opponent)
        {
            int damage = 10;
            opponent.Health -= damage;

            return new AttackResult(this, opponent, damage);
        }
        public bool IsAlive { get { return Health > 0; } }

        public abstract override string ToString();
    }
}
