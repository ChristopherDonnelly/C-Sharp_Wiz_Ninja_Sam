using System;
namespace Wiz_Ninja_Sam
{
    public class Human
    {
        public string name;

        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility

        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        /// <summary>
        /// Constructor Method for Human
        /// </summary>
        /// <param name="name">Name: Data Type (string)</param>
        public Human(string name)
        {
            this.name = name;
            this.strength = 3;
            this.intelligence = 3;
            this.dexterity = 3;
            this.health = 100;
        }

        /// <summary>
        /// Constructor Override Method for Human
        /// </summary>
        /// <param name="name">Name: Data Type (string)</param>
        /// <param name="strength">Strength: Data Type (int)</param>
        /// <param name="intelligence">Intelligence: Data Type (int)</param>
        /// <param name="dexterity">Dexterity: Data Type (int)</param>
        /// <param name="health">Health: Data Type (int)</param>
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
            this.health = health;
        }

        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }

        public override string ToString(){
            return $"****** Stats ******\n\tName: {this.name}\n\tStrength: {this.strength}\n\tIntelligence: {this.intelligence}\n\tDexterity: {this.dexterity}\n\tHealth: {this.health}\n*******************";
        }
    }
}