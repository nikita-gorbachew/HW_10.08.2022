// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int arraySize = 4;
int[,] array = new int[arraySize, arraySize];

int rows = 0;
int colums = 0;
int count = 1;
int maxRows = arraySize - 1;
int maxColums = arraySize - 1;
int minRows = 0;
int minColums = 0;

array[rows, colums] = count;
count++;
FillArray(array, rows, colums, minRows, maxRows, minColums, maxColums, count);

void FillArray(int[,] array, int rows, int colums, int minRows, int maxRows, int minColums, int maxColums, int count)
{
    while (colums < maxColums)
    {
        colums++;
        array[rows, colums] = count;
        count++;
    }
    minRows++;
    while (rows < maxRows)
    {
        rows++;
        array[rows, colums] = count;
        count++;
    }
    maxColums--;
    while (colums > minColums)
    {
        colums--;
        array[rows, colums] = count;
        count++;
    }
    maxRows--;
    while (rows > minRows)
    {
        rows--;
        array[rows, colums] = count;
        count++;
    }
    minColums++;
    if (array[rows, colums + 1] == 0) FillArray(array, rows, colums, minRows, maxRows, minColums, maxColums, count);
}

for (int i = 0; i < arraySize; i++)
{
    for (int j = 0; j < arraySize; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}