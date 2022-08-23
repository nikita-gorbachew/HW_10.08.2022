// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int sum = 0;
for (int i = 0; i < size; i++)
{
    if ((i+1) % 2 == 0) sum += array[i];
}
Console.Write("Сумма элементов, стоящих на нечетных позициях: " + sum);