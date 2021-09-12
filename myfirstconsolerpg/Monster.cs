﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstconsolerpg
{
   public class Monster : Character
    {
        public Monster(string _name, int _health, int _attack, int _speed)
            : base(_name, _health, _attack, _speed)
        {

        }
        
        public void Slash(Player target)
        {
            target.health -= attack;
            Console.WriteLine($"{name} used Slash and hit {target.name} for {attack} damage");
        }
    }
}
