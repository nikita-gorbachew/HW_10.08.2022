// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки A по оX ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки А по оY ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки A по оZ ");
int Az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки B по оX ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B по оY ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B по оZ ");
int Bz = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((Math.Pow(Bx-Ax,2)) + (Math.Pow(By-Ay,2)) + (Math.Pow(Bz-Az,2)));
Console.WriteLine($"Расстояние: {Math.Round(result,2)}");
