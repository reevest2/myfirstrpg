using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstconsolerpg
{
    public class Character
    {
        public string name;
        public int health;
        public int attack;

       public Character(string _name, int _health, int _attack)
        {
            name = _name;
            health = _health;
            attack = _attack;
        }
        public void DisplayStats()
        {
            Console.WriteLine(name + "Stats");
            Console.WriteLine("Health: {0}", health);
            Console.WriteLine("Attack: {0}", attack);
        }

     }
}

        

