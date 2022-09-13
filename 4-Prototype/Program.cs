using _4_Prototype.Interfaces;
using _4_Prototype.Implementations;

Rectangle rectangle = new Rectangle(100, 200, 0, 20);
IFigure recClone = rectangle.Clone();
IFigure recDeepClone = rectangle.DeepClone();

Circle circle = new Circle(40, 0, 20);
IFigure cirClone = circle.Clone();
IFigure cirDeepClone = circle.DeepClone();

rectangle.Point.X = 100;
circle.Point.X = 100;

rectangle.GetInfo();
recClone.GetInfo();
recDeepClone.GetInfo();

circle.GetInfo();
cirClone.GetInfo();
cirDeepClone.GetInfo();

Console.ReadLine();