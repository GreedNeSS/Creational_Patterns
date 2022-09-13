using _4_Prototype.Abstracts;
using _4_Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Prototype.Implementations
{
    public class Circle : AbstractFigure
    {
        public int Radius { get; set; }
        public Point Point { get; set; }

        public Circle(int radius, int posX, int posY)
        {
            Radius = radius;
            Point = new Point { X = posX, Y = posY };
        }

        public override void GetInfo()
        {
            string info = "\nCircle:\n";
            info += $"\nRadius = {Radius}";
            info += $"\nPosition = {Point.X} : {Point.Y}";
            info += $"\n____________________\n";
            Console.WriteLine(info);
        }
    }
}
