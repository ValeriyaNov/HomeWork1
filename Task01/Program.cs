// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

using static System.Console;
Console.Clear();
WriteLine("Введите число num1");
int num1 = Convert.ToInt32(ReadLine());
WriteLine("Введите число num2");
int num2 = Convert.ToInt32(ReadLine());

if (num1 > num2)
{
    WriteLine($"Большее число = {num1}, Меньшее число = {num2}");
}
else
{
    WriteLine($"Большее число = {num2}, Меньшее число = {num1}"); 
}