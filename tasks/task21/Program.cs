// Задача 21
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату x точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки A: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
Console.WriteLine($"Расстояние = {Math.Round(result, 2)}");
