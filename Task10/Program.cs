// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Пример 1: 456 -> 5
// Пример 1: 782 -> 8 
// Пример 1: 918 -> 1

Console.Clear();
Console.Write("Введите 3-х значное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a % 100 / 10);