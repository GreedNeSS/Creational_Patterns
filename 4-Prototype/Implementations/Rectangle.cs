using _4_Prototype.Abstracts;
using _4_Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Prototype.Implementations
{
    public class Rectangle : AbstractFigure
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Point Point { get; set; }

        public Rectangle(int width, int height, int posX, int posY)
        {
            Width = width;
            Height = height;
            Point = new Point() { X = posX, Y = posY };
        }

        public override void GetInfo()
        {
            string info = "\nRectangle:\n";
            info += $"\nWidth = {Width}";
            info += $"\nHeight = {Height}";
            info += $"\nPosition = {Point.X} : {Point.Y}";
            info += $"\n____________________\n";
            Console.WriteLine(info);
        }
    }
}
