// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Массив от 0 до N. Введите N: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
for (int i = 0; i < number; i++)
{
    array[i] = new Random().Next(0, 100);
}
Console.WriteLine(($"[{String.Join(", ", array)}]"));
