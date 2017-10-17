using System;

namespace human
{
    class Program
    {
        public class Human
        {
            public string name;
            public int strength = 3;
            public int intelligence = 3;
            public int dexterity = 3;
            public int health = 100;
            public Human(string newname = "John Doe")
            {
                name = newname;
            }
            public Human(string newname = "John Doe", int newstr = 3, int newint = 3, int newdex = 3, int newhtlh = 100)
            {
                name = newname;
                strength = newstr;
                intelligence = newint;
                dexterity = newdex;
                health = newhtlh;
            }
            public void Attack(object victim)
            {
                if (victim is Human)
                {
                    Human enemy = victim as Human;
                    enemy.health -= 5 * strength;
                }
            }
        }
        static void Main(string[] args)
        {
            Human jedi = new Human("Luke");
            Human sith = new Human("Darth");
            jedi.Attack(sith);
            System.Console.WriteLine(jedi.health);
            System.Console.WriteLine(sith.health);
        }
    }
}
