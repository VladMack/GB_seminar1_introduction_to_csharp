static int dogCounter(double distance, double firstFriendSpeed, double secondFriendSpeed, double dogSpeed, int friend, int counter)
{
    double time = 0;
    while (distance > 10)
    {
        if (friend == 1)
        {
            time = distance / (firstFriendSpeed + dogSpeed);
            friend = 2;
        }
        else
        {
            time = distance / (secondFriendSpeed + dogSpeed);
            friend = 1;
        }
        counter++;
        distance -= (firstFriendSpeed + secondFriendSpeed) * time;
    }
    return counter;
}

int counter = 0;
int friend = 2;

Console.WriteLine("Задача про друзей и собаку.");
Console.WriteLine("Расстояние, м:");
double distance = double.Parse(Console.ReadLine());
Console.WriteLine("Введите скорость первого друга, м/с:");
double firstFriendSpeed = double.Parse(Console.ReadLine());
Console.WriteLine("Введите скорость второго друга, м/с:");
double secondFriendSpeed = double.Parse(Console.ReadLine());
Console.WriteLine("Введите скорость собаки, м/с:");
double dogSpeed = double.Parse(Console.ReadLine());
Console.WriteLine("Собака пробежит " + dogCounter(distance, firstFriendSpeed, secondFriendSpeed, dogSpeed, friend, counter) + " раз.");