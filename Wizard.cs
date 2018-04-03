using System;

namespace Wiz_Ninja_Sam
{
    public class Wizard: Human
    {
        public Wizard(string name): base(name)
        {
            this.intelligence = 25;
            this.health = 50;
        }

        public Wizard Heal(){
            this.health += 10 * this.intelligence;
            return this;
        }

        public Wizard Fireball(object obj){
            if(obj is Human){
                Random rand = new Random();
                Human enemy = obj as Human;
                enemy.health -= rand.Next(20, 51);
            }
            return this;
        }
    }
}