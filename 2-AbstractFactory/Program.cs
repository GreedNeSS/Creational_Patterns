using _2_AbstractFactory.Factories;
using _2_AbstractFactory.Models;

Hero elf = new Hero(new ElfFactory());
elf.Move();
elf.Hit();

Hero warrior = new Hero(new WarriorFactory());
warrior.Move();
warrior.Hit();

Console.ReadLine();