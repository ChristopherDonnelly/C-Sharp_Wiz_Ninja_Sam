using System;

namespace Wiz_Ninja_Sam
{
    public class Ninja: Human
    {
        public Ninja(string name): base(name)
        {
            this.dexterity = 175;
        }

        public Ninja Steal(object obj){
            base.attack(obj);
            this.health += 10;

            return this;
        }

        public Ninja GetAway(){
            this.health -= 15;

            return this;
        }

    }
}