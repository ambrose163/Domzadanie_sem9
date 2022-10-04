// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n. 

using System;
Console.Clear();

int m = EnterInt("Enter integer positive number m: ");
int n = EnterInt("Enter integer positive number n: ");

Console.WriteLine(GetAckermannsFunction(m, n));

int EnterInt(string prompt)
{
      Console.Write(prompt);
      return int.Parse(Console.ReadLine()!);
}

int GetAckermannsFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) 
        return GetAckermannsFunction(m - 1, 1);
    return (GetAckermannsFunction(m - 1, GetAckermannsFunction(m, n - 1)));
}