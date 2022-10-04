// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

using System;
Console.Clear();

Console.Write("Input integer number N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetNaturalRow(N));

string GetNaturalRow (int N)
{
      if (N == 1)
            return "1";
      return N + ", " + GetNaturalRow(N - 1);
}