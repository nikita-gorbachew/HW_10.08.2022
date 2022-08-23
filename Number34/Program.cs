// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
Console.Write("Массив от 0 до N. Введите N: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size, 100, 999);
Console.WriteLine($"[{String.Join(", ", array)}]");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine("Четных чисел в массиве: " + count);
