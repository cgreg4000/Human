using System;

namespace Human
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health { get { return health; } }

        public Human(string n)
        {
            Name = n;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human(string n, int s, int i, int d, int h)
        {
            Name = n;
            Strength = s;
            Intelligence = i;
            Dexterity = d;
            health = h;
        }

        public int Attack(Human target)
        {
            target.health -= 5 * this.Strength;
            return target.health;
        }
    }
}