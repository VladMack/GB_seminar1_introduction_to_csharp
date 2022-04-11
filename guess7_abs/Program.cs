/*static int findAbs(int number)
{
    if (number >= 0)
    {
        return (number);
    }
    else
    {
        return (-number);
    }
}

Console.WriteLine("Введи число.");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Модуль числа: {findAbs(number)}");*/

Console.WriteLine("Введи число.");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Модуль числа: {Math.Abs(number)}");