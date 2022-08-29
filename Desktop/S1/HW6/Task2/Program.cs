// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите коэффициент наклона первой прямой");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свободный коэффициент первой прямой");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент наклона второй прямой");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свободный коэффициент второй прямой");
double b2 = Convert.ToDouble(Console.ReadLine());
double FindCrossX(double a, double b, double c, double d)
{
    double x = (d - c) / (a - b);
    return x;
}
double FindCrossY(double p1, double l1, double x)
{
    double y = p1 * x + l1;
    return y;
}
double newx = FindCrossX(k1, k2, b1, b2);
double newy = FindCrossY(k1, b1, newx);
if (k1 == k2 && b1 == b2){
    Console.WriteLine("Прямые совпадают");
}
else{
    if ((k1/k2) == (b1/b2)){
         Console.WriteLine("Прямые не пересекаются");
    }
    else{Console.WriteLine($"Точка - ({newx},{newy}) ");}
    
    }
