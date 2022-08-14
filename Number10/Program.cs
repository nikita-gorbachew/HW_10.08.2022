// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//С рандомным числом
/*
Console.WriteLine();
int number = new Random().Next(100, 1000);

Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

Console.WriteLine(); 
*/

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

