Console.WriteLine("Введи число.");
int number = int.Parse(Console.ReadLine());
int factorial = 1;
int numberTemp = number;
while (numberTemp >= 1)
{
    factorial *= numberTemp;
    numberTemp -= 1;
}
Console.WriteLine($"f({number}) = {factorial}");