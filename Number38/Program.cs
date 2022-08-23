// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}
Console.Write("Массив от 0 до N. Введите N: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size, 0, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");

double min = array[0];
double max = array[0];
for (int i = 0; i < size; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine($"Max({max}) - Min({min}) = {max - min}.");