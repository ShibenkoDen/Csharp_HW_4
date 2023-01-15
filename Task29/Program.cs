/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int [] CreateNewArray (int length)
{
    int [] array = new int [length];
    return array;
}

int [] FillArrayRandom (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int currentNumber = new Random().Next (0,100);
        array [i] = currentNumber;
    }
    return array;
}

void showArray(int [] array)
{
    Console.Write ("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write ($"{array[i]},");
    }
    Console.WriteLine ($"{array[array.Length-1]}]");
}

int [] emptyArr = CreateNewArray(8);
int [] arr = FillArrayRandom (emptyArr);
showArray (arr);