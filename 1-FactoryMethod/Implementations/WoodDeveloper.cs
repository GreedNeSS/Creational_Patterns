using _1_FactoryMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_FactoryMethod.Implementations
{
    public class WoodDeveloper : Developer
    {
        public WoodDeveloper(string name) : base(name)
        {
        }

        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
