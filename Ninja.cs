using System;
using System.Collections.Generic;

namespace wizardNinjaSamurai
{
    public class Ninja : Human
    {
        public Ninja(string n) : base(n)
        {
            dexterity = 175;
        }
        public void Steal(object obj)
        {
            Human target = obj as Human;
            {
                attack(target);
                health += 10;
            }
        }
        public void get_away()
        {
            health -= 15;
        }
    }
}