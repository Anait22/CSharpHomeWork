// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNumbers(n-1);
}
ShowNumbers(8);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfNumbers(int m, int n)
{
    if(m <= n) return m + SumOfNumbers(m + 1, n);
    else return 0;
}

Console.Write(SumOfNumbers(4,8));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;
    if(n == 0 && m > 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
    Console.Write($"m = {m}, n = {n} - > A(m,n) = {Akkerman} ");
}
Console.Write(Akkerman(3,2));
*/
