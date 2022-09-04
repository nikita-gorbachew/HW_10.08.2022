// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int maxValue = 100;
int minValue = 10;
int arraySize = 2;

int[,,] array = new int[arraySize, arraySize, arraySize];

int[] secondArray = new int[arraySize * arraySize * arraySize];
int temp;
for (int i = 0; i < secondArray.Length; i++)
{
    while (secondArray[i] == 0)
    {
        temp = new Random().Next(minValue, maxValue);
        if (Array.IndexOf(secondArray, temp, i) == -1)
        {
            secondArray[i] = temp;
        }
    }
}
int count = 0;
for (int i = 0; i < arraySize; i++)
{
    Console.Write("");
    for (int j = 0; j < arraySize; j++)
    {
        Console.Write("");
        for (int k = 0; k < arraySize; k++)
        {
            array[i, j, k] = secondArray[count];
            count++;
            Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}
