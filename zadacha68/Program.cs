//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AckermannFunc(m - 1, 1);
    return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}


Console.WriteLine(AckermannFunc(4, 1));