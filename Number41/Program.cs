// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество цифр: ");
int numberDigits = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numberDigits];
int count = 0;
for (int i = 0; i < numberDigits; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) count++;
}
Console.WriteLine($"Введено {count} чисел(ла) больше 0");

