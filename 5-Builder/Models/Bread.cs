using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Builder.Models
{
    public class Bread
    {
        public Flour? Flour { get; set; }
        public Salt? Salt { get; set; }
        public Additives? Additives { get; set; }

        public override string ToString()
        {
            string result = string.Empty;

            if (Flour != null)
            {
                result += Flour.Sort + "\n";
            }

            if (Salt != null)
            {
                result += "Соль \n";
            }

            if (Additives != null)
            {
                result += "Добавки: " + Additives.Name + "\n";
            }

            return result;
        }
    }
}
