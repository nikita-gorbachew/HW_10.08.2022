// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int maxValue = 10;
int minValue = 1;

int[,] array = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(minValue, maxValue);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
double average = 0; //ср. арифметическое
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        average += array[i, j];
    }
    average = Math.Round(average / rows, 2);
    Console.WriteLine($"Среднее арифметическое столбца {i + 1}: {average} ");
    average = 0;
}
Console.WriteLine();