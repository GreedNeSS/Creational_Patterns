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

        public string Date { get; private set; }
        public string Name { get; private set; }
        public static string Text { get; set; } = "text";

        private Singleton()
        {
            Console.WriteLine($"Singleton ctor {DateTime.Now.ToString("HH:mm:ss:ffff")}");
            Date = DateTime.Now.ToString("HH:mm:ss:ffff");
            Name = Guid.NewGuid().ToString();
        }

        public static Singleton GetInstance()
        {
            Console.WriteLine($"Singleton GetInstance {DateTime.Now.ToString("HH:mm:ss:ffff")}");
            return lazy.Value;
        }
    }
}
