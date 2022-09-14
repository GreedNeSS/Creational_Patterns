using _5_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Builder.Abstracts
{
    public abstract class BreadBuilder
    {
        public Bread Bread { get; private set; }

        public BreadBuilder()
        {
            Bread = new Bread();
        }

        public abstract void SetFlour();
        public abstract void SetSalt();
        public abstract void SetAdditives();
    }
}
