/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] arrayNumbers8(int min = 1, int max = 100)
{
    int[] array =new int [8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void writeNumbersArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("Введите минимальное значение для элементов массива");
int numMin = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение для элементов массива");
int numMax = int.Parse(Console.ReadLine());

int[] arrayNew = arrayNumbers8(numMin,numMax);
writeNumbersArray(arrayNew);