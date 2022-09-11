using _2_AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AbstractFactory.Implementations
{
    public class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Удар мечём.");
        }
    }
}
