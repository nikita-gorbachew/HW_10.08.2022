// Задача 47. Задайте двумерный массив размером m*n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int maxValue = 10;
int minValue = -10;

double[,] array = new double[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().NextDouble();
        array[i, j] = array[i, j] *(maxValue - minValue) + minValue;
        array[i, j] = Math.Round(array[i, j], 1);
        Console.Write( array[i, j] + " ");
    }
    Console.WriteLine();
}
