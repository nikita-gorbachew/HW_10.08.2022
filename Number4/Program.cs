﻿//Задание 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите 3 числа:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;
if (secondNumber > max)
{
    max = secondNumber;
}

if (thirdNumber > max)
{
    max = thirdNumber;
}

Console.WriteLine("Максимальное из этих чисел -> " + max);
