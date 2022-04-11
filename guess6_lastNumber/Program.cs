//Последняя цифра:
Console.WriteLine("Введи число.");
int number = int.Parse(Console.ReadLine());
int lastNumber = number % 10;
Console.WriteLine($"Последняя цифра: {lastNumber}");

//первая цифра 4-значного числа:
Console.WriteLine("Введи четырёхзначное число.");
int number1 = int.Parse(Console.ReadLine());
int lastNumber1 = number1 / 1000;
Console.WriteLine($"Первая цифра: {lastNumber1}");