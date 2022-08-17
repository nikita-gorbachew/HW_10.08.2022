// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if (number >9999 && number <100000) 
{
    int tempFirstDigit = number / 1000;
    int tempEndDigit = number % 100;
    if ((tempFirstDigit / 10 == tempEndDigit % 10) && (tempFirstDigit % 10 == tempEndDigit / 10)) 
    {
        Console.Write($"Число {number} является палиндромом!");
    }
    else
    {
        Console.Write($"Число {number} НЕ является палиндромом!");
    }
}
else
{
    Console.Write($"Число {number} не пятизначное или отрицательное!");
}