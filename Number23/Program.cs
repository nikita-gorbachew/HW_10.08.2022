﻿// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int cube = 1;
while (cube <= number)
{
    int result = cube * cube * cube;
    Console.Write(" " + result);
    cube++;
}
