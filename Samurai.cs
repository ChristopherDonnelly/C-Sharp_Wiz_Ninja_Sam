using System;

namespace Wiz_Ninja_Sam
{
    public class Samurai: Human
    {
        public static int Count { get; set; }

        public Samurai(string name): base(name)
        {
            this.health = 200;
            Samurai.Count++;
        }

        public Samurai DeathBlow(object obj){
            if(obj is Human){
                Human enemy = obj as Human;
                if(enemy.health < 50){
                    enemy.health = 0;
                }else{
                    base.attack(obj);
                }
            }

            return this;
        }

        public Samurai Meditate(){
            this.health = 200;

            return this;
        }

        public static int HowMany(){
            return Samurai.Count;
        }

    }
}