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
        public int speed;
       
        public Character(string _name, int _health, int _attack , int _speed)
        {
            name = _name;
            health = _health;
            attack = _attack;
            speed = _speed;
        }
        
        public void DisplayStats()
        {
            Console.WriteLine(name + " Stats");
            Console.WriteLine("Health: {0}", health);
            // Console.WriteLine("Attack: {0}", attack);
            // Console.WriteLine("Speed: {0}", speed);
        }
       
        public void HealthRemaining()
        {
            Console.WriteLine(name + " has health remaining: {0}", health);
        }
    }
}

