using _3_Singleton.Models;

(new Thread(() =>
{
    Singleton firstSingleton1 = Singleton.GetInstance();
    Console.WriteLine($"firstSingleton1.Name: {firstSingleton1.Name}");
}))
