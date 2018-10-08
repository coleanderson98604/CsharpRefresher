using System;

namespace HumanOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard test = new Wizard("Harry");
            human test2 = new human("jimmy");
            Ninja test3 = new Ninja("Genji");
            Samurai test4 = new Samurai("Jack");
            test.heal();
            test.fireball(test2);
            test.fireball(test2);
            test3.steal(test2);
            test3.run();
            test4.deathblow(test2);
            test4.meditate();

        }
    }
    public class human
    {
        public string name;
        public int strength {get;set;}
        public int Intelliegence {get;set;}
        public int Dexterity {get;set;}
        public int health  {get;set;}
        public human(string name)
        {
            this.name = name;
            this.strength = 3;
            this.Intelliegence = 3;
            this.Dexterity = 3;
            this.health = 100;
        }
        public void Attack(human player)
        {
            player.health -= (this.strength * 5);
            System.Console.WriteLine($"{player.name} took {(this.strength * 5)} of damage");
        }
    }
    public class Wizard : human
    {
        public Wizard(string name) : base(name)
        {
            this.health = 50;
            this.Intelliegence = 25;
        }
        public void heal()
        {
            this.health += 10 * this.Intelliegence;
            System.Console.WriteLine($"You healed {10 * this.Intelliegence}");
        }
        public void fireball(human enemy)
        {
            Random rand = new Random();
            int damage = rand.Next(20,51);
            enemy.health -= damage;
            System.Console.WriteLine($"{enemy.name} took {damage} points of damage from the fireball");
        }
    }
    public class Ninja : human
    {
        public Ninja(string name) : base(name)
        {
            this.Dexterity = 175;
        }
        public void steal(human enemy)
        {
            this.health += 10;
            enemy.health -= 10;
            System.Console.WriteLine($"you've stolen 10 health from {enemy.name}");
        }
        public void run()
        {
            this.health -= 15;
            System.Console.WriteLine("You've escaped, suffering 10 points of damage");
        }
    }
    public class Samurai : human
    {
        public Samurai(string name) : base(name)
        {
            this.health = 200;
        }
        public void deathblow(human enemy)
        {
            if(enemy.health < 50)
            {
                enemy.health = 0;
                System.Console.WriteLine($"Insta kill");
            }
            else
            {
                System.Console.WriteLine("Insta fail");
            }
        }
        public void meditate()
        {
            this.health = 200;
        }
    }
}
