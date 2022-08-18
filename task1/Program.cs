/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/

double numPow (double num = 1, int n = 0)
{
    double result = 1;
    for(int i = 0; i < n; i++) {result *= num;}
    return result;
}

Console.WriteLine("Выедите число");
double number = double.Parse(Console.ReadLine());
Console.WriteLine("Введите степень, в которую необходимо возвести число");
int exp = int.Parse(Console.ReadLine());

Console.WriteLine(numPow(number, exp));
