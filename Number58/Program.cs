// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int rows = 2;
int columns = 2;
int maxValue = 10;
int minValue = 1;

Console.WriteLine("Исходный массив A:");
int[,] matrixA = MatrixGenerator(rows, columns, maxValue, minValue);
Console.WriteLine("Исходный массив B:");
int[,] matrixB = MatrixGenerator(rows, columns, maxValue, minValue);

int[,] resultMatrix = new int[rows, columns];

Console.WriteLine("Произведение двух матриц:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        resultMatrix[i, j] = matrixA[i, j] * matrixB[i, j];
        Console.Write(resultMatrix[i, j] + "  ");
    }
    Console.WriteLine();
}

int[,] MatrixGenerator(int rows, int columns, int maxValue, int minValue)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}