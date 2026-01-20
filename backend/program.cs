/* Console.WriteLine("Hello, World!");
Console.WriteLine("Меня зовут Гвоздева В.А");
Console.WriteLine("Меня зовут Деушев Т.Т");
Console.WriteLine(DateTime.Now); */

Console.Write("Введите имя: ");
Console.WriteLine($"Привет, {Console.ReadLine()}!");
Console.WriteLine(DateTime.Now.DayOfWeek);

while(true)
{
    Console.Write("Хоите продолжить? (y/n): ");
    if (Console.ReadLine().ToLower() == "y")
    {
        Console.WriteLine("Заглушка");
    }
    else
    {
        Console.WriteLine("Выход из программы");
        break;
    }
}