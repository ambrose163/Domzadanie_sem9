//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumAllNumbs(int min, int max)
{
 int sum = 0;
    if (min == max)
    {
        return min;
    }
    sum += max;
    return SumAllNumbs(min, max - 1) + sum;
}
Console.WriteLine(SumAllNumbs(1, 10));