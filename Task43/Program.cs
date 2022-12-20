// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine()!);

void Cross(double a1, double c1, double a2, double c2)
{
    double x = (a1-a2)/(c2-c1);
    double y = c2*x +a2;
    Console.Write($"({x};{y})");
}

Cross(b1,k1,b2,k2);
