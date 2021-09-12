using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstconsolerpg
{
    public class Player : Character

    {
        int potion = 1;
        int maxhealth = 35;

        public Player(string _name, int _health, int _attack, int _speed)
            : base(_name, _health, _attack, _speed)
           
        {
        }

        public void Slash(Monster target)
        {
            target.health -= attack;
            Console.WriteLine($"{name} used Slash and hit {target.name} for {attack} damage");
        }

        public void Potion()
        {
            if (potion <= 0)
            { 
                Console.WriteLine("You don\'t have any potions!");
            }
            else if (health == maxhealth)
            {
                Console.WriteLine("You are already full health!");
            }
            else
            {
                potion -= 1;
                Console.WriteLine($"You gained {maxhealth - health} health");
                health = (health + 20) > maxhealth ? maxhealth : health + 20;
            }
       
        }
    }
}





