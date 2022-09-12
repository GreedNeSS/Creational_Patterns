using _3_Singleton.Models;

Console.WriteLine($"Used static field: {Singleton.Text}");

(new Thread(() =>
{
    Singleton firstSingleton1 = Singleton.GetInstance();
    Console.WriteLine($"firstSingleton1.Name: {firstSingleton1.Name}");
})).Start();

Singleton firstSingleton2 = Singleton.GetInstance();
Console.WriteLine($"firstSingleton2.Name: {firstSingleton2.Name}");

Console.WriteLine("\n_______________________\n");

Console.WriteLine($"Used static field: {Singleton.Text}");

(new Thread(() =>
{
    SecondSingleton secondSingleton1 = SecondSingleton.GetInstance();
    Console.WriteLine($"secondSingleton1.Name: {secondSingleton1.Name}");
})).Start();

SecondSingleton secondSingleton2 = SecondSingleton.GetInstance();
Console.WriteLine($"secondSingleton2.Name: {secondSingleton2.Name}");

Console.ReadLine();