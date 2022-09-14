using _5_Builder.Abstracts;
using _5_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Builder.Directors
{
    public class Baker
    {
        public Bread Bake(BreadBuilder builder)
        {
            builder.SetFlour();
            builder.SetSalt();
            builder.SetAdditives();
            return builder.Bread;
        }
    }
}
