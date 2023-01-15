/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetUserNumber (string message)
{
    Console.WriteLine (message);
    int number = int.Parse (Console.ReadLine ()!);
    return number;
}

int GetNumberSum (int number)
{
    int sum = 0;
    if (number < 0) number = number * -1;
    while (number > 0)
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    return sum;
}

int value = GetUserNumber ("Введите число:");
int result = GetNumberSum (value);
Console.WriteLine ($"Сумма цифр числа {value} равна {result}");