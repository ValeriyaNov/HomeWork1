// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
using static System.Console;
Console.Clear();
WriteLine("Введите число N");
int N = Convert.ToInt32(ReadLine());
int n = 1;
if (N == 1) { WriteLine("В рассматриваемом промежутке нет четных чисел"); }
while (n <= N)
{
      if ((n%2) == 0) {Write($"{n} ");}
      n++;
}