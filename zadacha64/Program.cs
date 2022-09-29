//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowAllNumbs(int num)
{
    if (num < 1)
    {
        Console.WriteLine();
        return;
    }
    Console.Write($"{num} ");
    ShowAllNumbs(num - 1);
}
ShowAllNumbs(9);