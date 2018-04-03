using System;

namespace Wiz_Ninja_Sam
{
    class Program
    {
        static void Main(string[] args)
        {
            Samurai chris = new Samurai("Chris");
            Samurai lawyer = new Samurai("Lawyer");
            Ninja ashley = new Ninja("Ashley");
            Wizard mark = new Wizard("Mark");
            Wizard tim = new Wizard("Tim");

            Console.WriteLine(chris);
            Console.WriteLine(ashley);
            Console.WriteLine(mark);
            Console.WriteLine(tim);
            
            mark.Heal().Fireball(lawyer);
            ashley.Steal(mark).GetAway();
            lawyer.DeathBlow(chris);
            chris.DeathBlow(tim).DeathBlow(tim).Meditate();

            Console.WriteLine(chris);
            Console.WriteLine(ashley);
            Console.WriteLine(mark);
            Console.WriteLine(tim);

            Console.WriteLine("Number of Samurai: "+Samurai.HowMany());
        }
    }
}
