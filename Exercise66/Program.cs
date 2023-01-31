// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());

void NumberSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов = {sum}"); 
        return;
    }
    sum = sum + (M++);
    NumberSum(M, N, sum);
}

NumberSum(M, N, 0);
