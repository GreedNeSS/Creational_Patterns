using _5_Builder.Abstracts;
using _5_Builder.Builders;
using _5_Builder.Directors;
using _5_Builder.Models;

Baker baker = new Baker();
BreadBuilder breadBuilder = new RyeBreadBuilder();
Bread bread = baker.Bake(breadBuilder);
Console.WriteLine(bread);

breadBuilder = new WheatBreadBuilder();
bread = baker.Bake(breadBuilder);
Console.WriteLine(bread);

Console.ReadLine();