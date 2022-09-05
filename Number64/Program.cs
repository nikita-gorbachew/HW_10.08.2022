// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < M) return;
/*void PrintNumbers(int start, int end)
{
    if (end > start)
    {
        PrintNumbers(start, end - 1);
        Console.Write(", ");
    }
    Console.Write(end);
}
PrintNumbers(M, N);
Console.WriteLine();
*/
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString(); // Базовый случай
    return (start + ", " + PrintNumbers(start + 1, end)); // Рекурсивный случай
}

Console.WriteLine(PrintNumbers(M, N));