using _1_FactoryMethod.Implementations;
using _1_FactoryMethod.Abstracts;

Developer dev = new PanelDeveloper("ВнешСтрой");
House house = dev.Create();

dev = new WoodDeveloper("СтримПилим");
house = dev.Create();

Console.ReadLine();