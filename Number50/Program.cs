// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)

Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int maxValue = 100;
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
Console.Write("Введите строку: ");
int enterRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int enterColumns = Convert.ToInt32(Console.ReadLine());

if (enterRow <= rows && enterColumns <= columns)
{
    Console.WriteLine($"Ваше число: " + array[enterRow - 1, enterColumns - 1]);
}
else Console.WriteLine("Такого числа НЕТ");
