Console.WriteLine($"Введи первое число:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Введи второе число:");
int number2 = int.Parse(Console.ReadLine());

if (number2 == number1 * number1)
{
    Console.WriteLine($"a = {number1}; b = {number2} -> да");
}
else
{
    Console.WriteLine($"a = {number1}; b = {number2} -> нет");

}