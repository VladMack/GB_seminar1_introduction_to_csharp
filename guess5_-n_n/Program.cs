Console.WriteLine("Введи число.");
int number = int.Parse(Console.ReadLine());
int counter = -number;
while (counter <= number)
{
    Console.Write($"{counter} ");
    counter++;
}