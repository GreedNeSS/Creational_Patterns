using _5_Builder.Abstracts;
using _5_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Builder.Builders
{
    public class RyeBreadBuilder : BreadBuilder
    {
        public override void SetAdditives()
        {
            Bread.Flour = new Flour { Sort = "Ржаная мука 1 сорт" };
        }

        public override void SetFlour()
        {
            Bread.Salt = new Salt();
        }

        public override void SetSalt()
        {
            
        }
    }
}
