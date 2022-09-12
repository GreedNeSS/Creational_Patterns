using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Singleton.Models
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public string? Name { get; private set; }

        private Singleton()
        {
            Name = Guid.NewGuid().ToString();
        }

        public static Singleton GetInstance()
        {
            return lazy.Value;
        }
    }
}
