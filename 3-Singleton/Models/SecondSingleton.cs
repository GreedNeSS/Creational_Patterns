using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Singleton.Models
{
    public class SecondSingleton
    {
        public string Date { get; private set; }
        public string Name { get; private set; }
        public static string Text { get; set; } = "text";

        private SecondSingleton()
        {
            Console.WriteLine($"Singleton ctor {DateTime.Now.ToLongTimeString()}");
            Date = DateTime.Now.ToLongTimeString();
            Name = Guid.NewGuid().ToString();
        }

        private class Nested
        {
            static Nested() { }
            internal static readonly SecondSingleton instance = new SecondSingleton();
        }

        public static SecondSingleton GetInstance()
        {
            Console.WriteLine($"Singleton GetInstance {DateTime.Now.ToLongTimeString()}");
            return Nested.instance;
        }
    }
}
