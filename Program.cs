using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Human jon = new Human("Jonathan");
            Human ben = new Human("Benjamin", 5, 5, 5, 150);
            Console.WriteLine(ben.Strength);
            Console.WriteLine(ben.getHealth);
            jon.Attack(ben);
            Console.WriteLine(ben.getHealth);
        }
    }

    public class Human
    {
        // Fields (attributes)
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int getHealth
        {
            get
            {
                return health;
            }
        }

        // Constructor
        public Human(string nameInput)
        {
            Name = nameInput;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string nameInput, int strengthInput, int intelligenceInput, int dexterityInput, int healthInput)
        {
            Name = nameInput;
            Strength = strengthInput;
            Intelligence = intelligenceInput;
            Dexterity = dexterityInput;
            health = healthInput; // private, will this work?
        }

        // Methods
        public int Attack(Human target)
        {
            int damage = 5 * this.Strength;
            target.health -= damage;
            return target.health;
        }
    }
}
