﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Player
    {
        public void Attack(int damage)
        {
            Console.WriteLine($"I attacked {damage}!");
        }

        public void Attack(int damage, string weapon, int numTimes)
        {
            int totalDamage = damage * numTimes;
            Console.WriteLine();
        }
    }
}
