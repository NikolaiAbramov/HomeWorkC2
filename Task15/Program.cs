// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Пример:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите день недели(от 1 до 7): ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 6 || n == 7)
Console.WriteLine("да");
else 
Console.WriteLine("нет");


// или такой вариант, если число неправильно вводят:
// Console.Clear();
// Console.Write("Введите день недели(от 1 до 7): ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 || n > 7)
// {
//     Console.Write("Вы ошиблись!\nВведите день недели(от 1 до 7): ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// if (n == 6 || n == 7)
// Console.WriteLine("да выходной можешь отдохнуть");
// else 
// Console.WriteLine("нет увы работай дальше");