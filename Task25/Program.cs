/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetUserNumber (string message)
{
    Console.WriteLine (message);
    int number = int.Parse (Console.ReadLine ()!);
    return number;
}

int GetNumberPow (int number1, int number2)
{
    if (number2 >= 0)
    {
        int res = 1;
        for (int i = 1; i <= number2; i++)
            {
                res = res * number1;
            }
        return (res);
    }
    else 
    {
        int res = 0;
        return (res);
    }
}

int numberA = GetUserNumber ("Введите число А:");
int numberB = GetUserNumber ("Введите положительное число В:");
int result = GetNumberPow (numberA, numberB);
if (result !=0 ) Console.WriteLine ($"Результат возведения числа {numberA} в степень {numberB} равен {result}");
else 
{
    Console.WriteLine ("Ошибка! Введено отрицательное число B");
}