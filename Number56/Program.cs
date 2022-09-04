// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
//  с наименьшей суммой элементов: 1 строка

int rows = 4;
int columns = 4;
int maxValue = 10;
int minValue = 1;

int[,] array = new int[rows, columns];

int minString = Int32.MaxValue;
int indexMinString = -1;
for (int i = 0; i < rows; i++)
{
    int sumStringElement = 0;
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(minValue, maxValue);
        Console.Write(array[i, j] + " ");
        sumStringElement += array[i, j];
    }
    Console.WriteLine($"({i + 1}) сумма = {sumStringElement}");
    if (sumStringElement < minString)
    {
        minString = sumStringElement;
        indexMinString = i;
    }
}
Console.WriteLine($"Строка ({indexMinString + 1}) с наименьшей суммой элементов.");