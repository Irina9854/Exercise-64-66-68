// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
PrintNumbers(number, count);


void PrintNumbers(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        PrintNumbers(n, count + 1);
        Console.Write(count + " ");
    }
}